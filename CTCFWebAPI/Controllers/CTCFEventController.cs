using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CTCFDataAccess;

namespace CTCFWebAPI.Controllers
{
    public class CTCFEventController : ApiController
    {
        public IEnumerable<Event> Get()
        {
            using (masterEntities entities = new masterEntities()) 
            {
                return entities.Events.ToList();
            }
        }

        public Event Get(int Id)
        {
            using (masterEntities entities = new masterEntities())
            {
                return entities.Events.FirstOrDefault(e => e.Id == Id);
            }
        }
    }
}
