using System;
using Netix.Common;
using Netix.Interfaces;
using Netix.Triceps.Core.Entities;

namespace WpfPanels.MockPanels
{
    public class MockDocumentPayment : IDocumentPayment
    {
        public SimpleCommand ShowFromCommand { get; }
        public SimpleCommand ShowToCommand { get; }
        public bool IsExtraFromVisible { get; set; }
        public bool IsExtraToVisible { get; set; }
        public Payment Payment { get; }
        public TricepsEntityBase Reference { get; set; }
        public string Reason { get; set; }
        public double Amount { get; set; }
        public Agent From { get; set; }
        public Agent LegalFrom { get; set; }
        public Agent FromDiffers { get; set; }
        public Agent To { get; set; }
        public Agent LegalTo { get; set; }
        public Agent ToDiffers { get; set; }
        public bool Cheque { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime ChequeDateTime { get; set; }
        public string DocumentChequeNumber { get; }
        public User Responsible { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public DateTime DateTime { get; set; }
        public string SignatureInfo { get; }
        public DateTime SignedDateTime { get; }
    }
}
