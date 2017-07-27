using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDBforJsonDataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileData = File.ReadAllText(ConfigurationManager.AppSettings["jsonPath"].ToString());
            var obj = JsonConvert.DeserializeObject<Rootobject>(fileData);

            using (var ctx = new PolicyContext())
            {
                Policy policy = new Policy();
                policy.ID = obj.policy.policy_id;
                policy.policy_id = obj.policy.policy_id;
                policy.record_id = obj.policy.record_id;
                policy.product_code = obj.policy.product_code;
                policy.reference = obj.policy.reference;
                policy.status_code = obj.policy.status_code;
                policy.status_description = obj.policy.status_description;
                policy.product_version = obj.policy.product_version;
                policy.converted = obj.policy.converted;
                policy.created = obj.policy.created;
                policy.period_start = obj.policy.period_start;
                policy.effective_from = obj.policy.effective_from;
                policy.period_end = obj.policy.period_end;
                policy.country_code = obj.policy.country_code;
                policy.lang = obj.policy.lang;


                Client client = new Client();
                client.id = obj.policy.client.id;
                client.number = obj.policy.client.number;
                policy.client = client;

                Agency agency = new Agency();
                agency.id = obj.policy.agency.id;
                agency.name = obj.policy.agency.name;
                agency.number = obj.policy.agency.number;
                policy.agency = agency;

                Binder binder = new Binder();
                binder.id = obj.policy.binder.id;
                binder.description = obj.policy.binder.description;
                binder.version = obj.policy.binder.version;
                policy.binder = binder;

                List<Page> pages = new List<Page>();
                foreach (var page in obj.policy.pages)
                {
                    if (page.questions != null)
                        page.questions.id = page.pageid + "_q";
                    pages.Add(page);
                }
                policy.pages = pages;

                List<Section> sections = new List<Section>();
                foreach (var section in obj.policy.sections)
                {

                    foreach (var page in section.pages)
                    {
                        page.ID = page.pageid;
                        if (page.questions != null)
                            page.questions.id = page.ID + "_q";
                    }
                    sections.Add(section);
                }
                policy.sections = sections;

                
                
                policy.totalannualpremium = obj.policy.totalannualpremium; ;

                
                policy.totaltransactionpremium = obj.policy.totaltransactionpremium;

                List<Endorsement> endorsements = new List<Endorsement>();
                foreach (var endorsement in obj.policy.endorsements)
                {
                    endorsements.Add(endorsement);
                }
                policy.endorsements = endorsements;

                ctx.Policy.Add(policy);
                ctx.SaveChanges();
            }

        }
    }
    
}
