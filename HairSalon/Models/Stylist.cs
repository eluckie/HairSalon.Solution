using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime HireDate { get; set; }
    public List<Client> Clients { get; set; }
  }
}