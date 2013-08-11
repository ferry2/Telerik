namespace MusicStore.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using MusicStore.Models;

    public class ArtistsController : ApiController
    {
        private MusicStoreDb db = new MusicStoreDb();

        // GET api/Artists
        public IEnumerable<ArtistModel> GetArtistModels()
        {
            return db.Artists.AsEnumerable();
        }

        // GET api/Artists/5
        public ArtistModel GetArtistModel(int id)
        {
            ArtistModel artistmodel = db.Artists.Find(id);
            if (artistmodel == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return artistmodel;
        }

        // PUT api/Artists/5
        public HttpResponseMessage PutArtistModel(int id, ArtistModel artistmodel)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != artistmodel.ArtistId)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(artistmodel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Artists
        public HttpResponseMessage PostArtistModel(ArtistModel artistmodel)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(artistmodel);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, artistmodel);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = artistmodel.ArtistId }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Artists/5
        public HttpResponseMessage DeleteArtistModel(int id)
        {
            ArtistModel artistmodel = db.Artists.Find(id);
            if (artistmodel == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Artists.Remove(artistmodel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, artistmodel);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}