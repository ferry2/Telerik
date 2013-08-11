using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class ArtistController : ApiController
    {
        private MusicStoreDb db = new MusicStoreDb();

        // GET api/Artist
        public IEnumerable<ArtistModel> GetArtists()
        {
            return db.Artists.AsEnumerable();
        }

        // GET api/Artist/5
        public ArtistModel GetArtist(int id)
        {
            ArtistModel artist = db.Artists.Find(id);
            if (artist == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return artist;
        }

        // PUT api/Artist/5
        public HttpResponseMessage PutArtist(int id, ArtistModel artist)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != artist.ArtistId)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(artist).State = EntityState.Modified;

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

        // POST api/Artist
        public HttpResponseMessage PostArtist(ArtistModel artist)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(artist);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, artist);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = artist.ArtistId }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Artist/5
        public HttpResponseMessage DeleteArtist(int id)
        {
            ArtistModel artist = db.Artists.Find(id);
            if (artist == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Artists.Remove(artist);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, artist);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}