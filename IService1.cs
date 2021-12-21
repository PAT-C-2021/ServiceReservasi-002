using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelepon, int JUmlahPemesanan, string IDLokasi);

        [OperationContract]
        string editpemesanan(string IDPemesanan, string NamaCustomer);

        [OperationContract]
        string deletpemesanan(string IDPemesanan);

        [OperationContract]
        List<CekLokasi> ReviewLokasi();

        [OperationContract]
        List<DetailLokasi> DetailLokasi();

        [OperationContract]
        List<pemesanan> pemesanan();

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceReservasi1.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class CekLokasi  //daftar lokasi nongkrong
    {
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeksripsiSingkat { get; set; }
    }

    [DataContract]
    public class DetailLokasi //menampilkan detail lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; }
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiFull { get; set; }
        [DataMember]
        public int kuota { get; set; }

    }

    [DataContract]
    public class pemesanan // create
    {
        [DataMember]
        public string IDPemesanan { get; set; }
        [IgnoreDataMember]
        public string NamaCustomer { get; set; }  //method
        [DataMember]
        public string NoTelpon { get; set; }
        [DataMember]
        public int JumlahPemesanan { get; set; }
        [DataMember]
        public string Lokasi { get; set; }

    }


}
