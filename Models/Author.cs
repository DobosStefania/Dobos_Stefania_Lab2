using Microsoft.CodeAnalysis.Differencing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Reflection.Metadata.BlobBuilder;

namespace Dobos_Stefania_Lab2.Models
{
    public class Author
    {
        public string AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}

    }
}
