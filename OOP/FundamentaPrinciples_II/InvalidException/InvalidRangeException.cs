using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InvalidException
{
    /// <summary>
    /// Holds information about an error condition related to invalid range.
    /// </summary>
    /// <typeparam name="T">Numeric type.</typeparam>
    [Serializable]
    public class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {        
        /// <summary>
        /// Starting point of the range.
        /// </summary>
        private T start;

        /// <summary>
        /// End point of the range.
        /// </summary>
        private T end;

        /// <summary>
        /// Error value that cause the exception.
        /// </summary>
        private T errorValue;                

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRangeException{T}" /> class.
        /// </summary>
        public InvalidRangeException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRangeException{T}" /> class, with specified message.
        /// </summary>
        /// <param name="msg">Exception message.</param>
        public InvalidRangeException(string msg)
            : base(msg)
        {            
        }       

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRangeException{T}" /> class, with specified message, start and end point for the range.
        /// </summary>
        /// <param name="msg">Exception message.</param>
        /// <param name="start">Starting point of the specified range.</param>
        /// <param name="end">End point of the specified range.</param>
        public InvalidRangeException(string msg, T start, T end)
            : this(msg)
        {
            this.start = start;
            this.end = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRangeException{T}" /> class, with specified message, start, end point for the range and error value causes the exception.
        /// </summary>
        /// <param name="msg">Exception message.</param>
        /// <param name="start">Starting point of the specified range.</param>
        /// <param name="end">End point of the specified range.</param>
        /// <param name="errorValue">The value that cause the error.</param>
        public InvalidRangeException(string msg, T start, T end, T errorValue)
            : this(msg, start, end)
        {
            this.errorValue = errorValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidRangeException{T}" /> class that provide serialization option.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected InvalidRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {           
        }
        
        /// <summary>
        /// Gets and sets the start of the range.
        /// </summary>
        public T Start
        {
            get { return this.start; }
            private set { this.start = value; }
        }

        /// <summary>
        /// Gets and sets return the end of the range.
        /// </summary>
        public T End
        {
            get { return this.end; }
            private set { this.end = value; }
        }

        /// <summary>
        /// Gets and sets return the error value.
        /// </summary>
        public T ErrorValue
        {
            get { return this.errorValue; }
            private set { this.errorValue = value; }
        }

        /// <summary>
        /// Gets the exception message. Overriden Message property.
        /// </summary>
        public override string Message
        {
            get
            {
                string message = string.Format(
                    "The value {0} is out of the range [{1} ; {2}].", 
                    this.errorValue, 
                    this.start, 
                    this.end);
                return message;
            }
        }

        /// <summary>
        /// Overridden ToString method for <see cref="InvalidRangeException{T}" /> class.
        /// </summary>
        /// <returns>Error message.</returns>
        public override string ToString()
        {
            return this.Message + base.ToString();
        }

        /// <summary>
        /// Overridden GetObjectData method for <see cref="InvalidRangeException{T}" /> class.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            info.AddValue("Start", this.Start);
            info.AddValue("End", this.End);
            info.AddValue("Error value", this.ErrorValue);
            base.GetObjectData(info, context);
        }
    }
}
