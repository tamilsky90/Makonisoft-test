using Makonisoft.Common;
using Makonisoft.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Makonisoft.Facade
{
    public class PersonalInformationFacade
    {
        public PersonalInformationDTO SavePersonalInformation(PersonalInformationDTO personalInformationDTO)
        {
            List<PersonalInformationDTO> personalInformationDTOs = new List<PersonalInformationDTO>();
            string path = System.Web.HttpContext.Current.Server.MapPath(CommonValues.PersonalInfomationSavePath);
            string filePath = path + CommonValues.PersonalInformationFilename;
            if (System.IO.File.Exists(filePath))
            {
                string personalJson = System.IO.File.ReadAllText(filePath);
                personalInformationDTOs = JsonConvert.DeserializeObject<List<PersonalInformationDTO>>(personalJson);
                if (personalInformationDTO.Id > 0)
                    personalInformationDTOs.Where(p => p.Id == personalInformationDTO.Id).Select(p => { p.Id =personalInformationDTO.Id; p.FirstName = personalInformationDTO.FirstName; p.LastName = personalInformationDTO.LastName; return p; }).ToList();
                else
                {
                    personalInformationDTO.Id = personalInformationDTOs.OrderByDescending(p => p.Id).FirstOrDefault().Id + 1;
                    personalInformationDTOs.Add(personalInformationDTO);
                }

            }
            else
            {
                personalInformationDTO.Id = 1;
                personalInformationDTOs.Add(personalInformationDTO);
            }
            FileHelper.SaveText(path, CommonValues.PersonalInformationFilename, JsonConvert.SerializeObject(personalInformationDTOs));
            return personalInformationDTO;
        }
    }
}