namespace Blazor.StorageAPITest.Model
{
    public class Artikel
    {
        public int Id { get; set; }
        public int AktionsKriterium { get; set; }
        public string Artikelbezeichnung { get; set; }
        public string ArtikelNr { get; set; }
        public string Barcode { get; set; }
        public int BestandAktuell { get; set; }
        public int BestandDefekt { get; set; }
        public int BestandRetourniert { get; set; }
        public int EntwertungKZ { get; set; }
        public string ExternArtikelNr { get; set; }
        public int FarbenCode { get; set; }
        public int Festpreis { get; set; }
        public int Filiale { get; set; }
        public int Firma { get; set; }
        public int Garantiefrist { get; set; }
        public string Groesse { get; set; }
        public int GrundNr { get; set; }
        public int ISOCode { get; set; }
        public int LieferantNr { get; set; }
        public int MaxBestellmenge { get; set; }
        public int MwstKZ { get; set; }
        public int Preis { get; set; }
        public int PreisNeu { get; set; }
        public int Saison { get; set; }
        public int Sonderpreis { get; set; }
        public DateTime TSPLUArtikel { get; set; }
        public int Unverkaeuflich { get; set; }
        public int WarengruppeNR { get; set; }
        public int ZentralPreis { get; set; }
        public int ZugabeArtikel { get; set; }

        public byte[]? Image { get; set; }

        public static Artikel GenerateRandom(byte[]? image)
        {
            int artikelNr = Random.Shared.Next(999999999);
            return new Artikel
            {
                AktionsKriterium = Random.Shared.Next(10),
                Artikelbezeichnung = $"Langer Artikeltext {Random.Shared.Next(9999)}",
                Barcode = artikelNr.ToString("00000000000000000000"),
                ArtikelNr = artikelNr.ToString(),
                BestandAktuell = Random.Shared.Next(10),
                BestandDefekt = Random.Shared.Next(10),
                BestandRetourniert = Random.Shared.Next(10),
                EntwertungKZ = Random.Shared.Next(10),
                ExternArtikelNr = Random.Shared.Next(10).ToString(),
                FarbenCode = Random.Shared.Next(10),
                Festpreis = Random.Shared.Next(10),
                Filiale = Random.Shared.Next(10),
                Firma = Random.Shared.Next(10),
                Garantiefrist = Random.Shared.Next(10),
                Groesse = Random.Shared.Next(10).ToString(),
                GrundNr = Random.Shared.Next(10),
                ISOCode = Random.Shared.Next(10),
                LieferantNr = Random.Shared.Next(10),
                MaxBestellmenge = Random.Shared.Next(10),
                MwstKZ = Random.Shared.Next(10),
                Preis = Random.Shared.Next(10),
                PreisNeu = Random.Shared.Next(10),
                Saison = Random.Shared.Next(10),
                Sonderpreis = Random.Shared.Next(10),
                TSPLUArtikel = DateTime.Now.AddMilliseconds(Random.Shared.Next(10)),
                Unverkaeuflich = Random.Shared.Next(10),
                WarengruppeNR = Random.Shared.Next(10),
                ZentralPreis = Random.Shared.Next(10),
                ZugabeArtikel = Random.Shared.Next(10),
                Image = image?.Length > 0 ? image : null
            };
        }
    }
}
