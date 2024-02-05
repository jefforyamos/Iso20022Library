using BeneficialStrategies.Iso20022.Components;
using Xunit.Abstractions;
using Iso = BeneficialStrategies.Iso20022;

namespace BeneficialStrategies.Iso20022.Components;

public class CreditTransferTransaction54_A : TestPublishedSample<CreditTransferTransaction54>
{
    public CreditTransferTransaction54_A(ITestOutputHelper output) : base(output)
    {
    }

    protected override CreditTransferTransaction54 Sample => new()
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
            Structured = [
                            new()
                            {
                                ReferredDocumentInformation =
                                [
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
                                ],
                            }
                        ],
        },
    };

}
