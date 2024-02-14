
using System.Reflection;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics1Choice;
using Xunit.Abstractions;
using Iso = BeneficialStrategies.Iso20022;

namespace BeneficialStrategies.Iso20022.pain;

#if DECLARE_INTERNALSERIALIZATION

/// <summary>
/// Unit test for POC data
/// </summary>
public class CustomerCreditTransferInitiation : TestPublishedOuterRecordSample<Iso.pain.CustomerCreditTransferInitiationV11, Iso.pain.CustomerCreditTransferInitiationV11Document>
{
    // https://www.iso20022.org/sites/default/files/2020-12/ISO20022_MDRPart1_PaymentsInitiation_2020_2021_v1_ForSEGReview.docx&ved=2ahUKEwjR39GZiomEAxX0TjABHSDID0oQFnoECB0QAQ&usg=AOvVaw0eSycRPoG1iFrAN0py8ziP&sxs=sb
    // https://www.google.com/url?sa=t&source=web&rct=j&opi=89978449&url=https://www.iso20022.org/sites/default/files/2020-12/ISO20022_MDRPart1_PaymentsInitiation_2020_2021_v1_ForSEGReview.docx&ved=2ahUKEwjR39GZiomEAxX0TjABHSDID0oQFnoECB0QAQ&usg=AOvVaw0eSycRPoG1iFrAN0py8ziP&sxs=sb

    public CustomerCreditTransferInitiation(ITestOutputHelper output) : base(output)
    {
    }

    protected override CustomerCreditTransferInitiationV11 Sample => new()
    {
        GroupHeader = new()
        {
            MessageIdentification = "ABC/120928/CCT001",
            CreationDateTime = new DateTime(2012, 09, 28, 14, 7, 0),
            NumberOfTransactions = "3",
            ControlSum = 11500000,
            InitiatingParty = new()
            {
                Name = "ABC Corporation",
                PostalAddress = new()
                {
                    StreetName = "Times Square",
                    BuildingNumber = "7",
                    PostCode = "NY 10036",
                    TownName = "New York",
                    Country = "US"
                },
            },
        },
        PaymentInformation = new()
        {
            PaymentInformationIdentification = "ABC/086",
            PaymentMethod = Codesets.PaymentMethod3Code.CreditTransfer,
            BatchBooking = "FALSE",
            RequestedExecutionDate = new Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2012, 09, 29) },
            Debtor = new()
            {
                Name = "ABC Corporation",
                PostalAddress = new()
                {
                    StreetName = "Times Square",
                    BuildingNumber = "7",
                    PostCode = "NY 10036",
                    TownName = "New York",
                    Country = "US"
                },
            },
            DebtorAccount = new()
            {
                Identification = new Choices.AccountIdentification4Choice.Other
                {
                    Identification = "00125574999",
                },
            },
            DebtorAgent = new()
            {
                FinancialInstitutionIdentification = new Components.FinancialInstitutionIdentification18
                {
                    BICFI = "BBBBUS33",
                },
            },
            CreditTransferTransactionInformation =
            
                new()
                {
                    PaymentIdentification = new Components.PaymentIdentification6
                    {
                        InstructionIdentification = "ABC/120928/CCT001/1",
                        EndToEndIdentification = "ABC/4562/2012-09-08",
                    },
                    Amount = new Choices.AmountType4Choice.InstructedAmount { Value = 10_000_000m },
                    ChargeBearer = Codesets.ChargeBearerType1Code.Shared,
                    CreditorAgent = new()
                    {
                        FinancialInstitutionIdentification = new()
                        {
                            BICFI = "AAAAGB2L",
                        },
                    },
                    Creditor = new()
                    {
                        Name = "DEF Electronics",
                        PostalAddress = new()
                        {
                            AddressLine = [
                                "Corn Exchange 5th Floor",
                                "Mark Lane 55",
                                "EC#R7NE London",
                                "GB"
                                ]
                        },
                    },
                    CreditorAccount = new()
                    {
                        Identification = new Choices.AccountIdentification4Choice.Other
                        {
                            Identification = "23683707994215",
                        },
                    },
                    Purpose = new Choices.Purpose2Choice.Code
                    {
                        Value = Codesets.ExternalPurpose1Code.InstantPaymentsForDonations, // Todo: What should this be??
                    },
                    RemittanceInformation = new()
                    {
                        Structured = 
                            new()
                            {
                                ReferredDocumentInformation =
                                
                                    new()
                                    {
                                        Type = new()
                                        {
                                            CodeOrProprietary = new Choices.ReferredDocumentType3Choice.Code
                                            {
                                                Value = Codesets.DocumentType6Code.CommercialInvoice,
                                            },
                                        },
                                        Number = "4562",
                                        RelatedDate = new DateOnly(2012,09,08),
                                    }
                                ,
                            }
                        ,
                    },
                },
                // Last transaction
            
        },
    };
}

#endif
