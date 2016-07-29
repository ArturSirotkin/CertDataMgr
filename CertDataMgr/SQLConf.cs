using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.XPath;

namespace CertSQL
{
    class SQLCon
    {
        // TODO: The app should read the SQL Connection string from an XML file instead from an source file
        public SqlConnection DBConfig = new SqlConnection("Server=127.0.0.1,1433;Database=_Certification;User=sa;Password=");
        public SqlCommand SQLCMD;
        public SqlDataReader SQLReader;
    }
}
