using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using www.sugiro.net;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCertificate();
        }

        private static void TestCertificate()
        {
            var service = new Service1Client();

            X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);

            foreach (X509Certificate2 cert in store.Certificates)
            {
                var str = ("Cert: " + cert.FriendlyName);
            }

            //X509Certificate2Collection CertColl = Store.Certificates.Find(X509FindType.FindByIssuerName, "Microsoft", true);
            //foreach (X509Certificate2 Cert in CertColl)
            //{
            //    var str = ("Cert: " + Cert.IssuerName.Name);
            //}

            if (service.ClientCredentials != null)
            {
                service.ClientCredentials.ClientCertificate.SetCertificate(StoreLocation.LocalMachine, StoreName.CertificateAuthority,
                    X509FindType.FindByIssuerName, "OP");

                var x = service.ClientCredentials.ClientCertificate;
            }

            ((BasicHttpBinding)service.Endpoint.Binding).Security.Mode = BasicHttpSecurityMode.Transport;
            ((BasicHttpBinding)service.Endpoint.Binding).Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;

            var res = service.ConsultDeposit(new ConsultDepositRequestBody());
        }
    }
}
