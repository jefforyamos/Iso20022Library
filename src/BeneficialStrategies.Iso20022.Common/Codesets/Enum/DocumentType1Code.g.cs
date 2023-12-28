﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DocumentType1Code.  ISO2002 ID# _axXO1Np-Ed-ak6NoX_4Aeg_1703334295.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axXO1Np-Ed-ak6NoX_4Aeg_1703334295")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
public enum DocumentType1Code
{
    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.
    /// Encoded/decoded by serializers as "MeteredServiceInvoice".
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_axXO1dp-Ed-ak6NoX_4Aeg_1703334296")]
    [Description(@"Document is an invoice claiming payment for the supply of metered services, for example gas or electricity supplied to a fixed meter.")]
    MeteredServiceInvoice,
    
    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as "CreditNoteRelatedToFinancialAdjustment".
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_axXO1tp-Ed-ak6NoX_4Aeg_1703334297")]
    [Description(@"Document is a credit note for the final amount settled for a commercial transaction.")]
    CreditNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// Document is a debit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as "DebitNoteRelatedToFinancialAdjustment".
    /// </summary>
    [EnumMember(Value = "DNFA")]
    [IsoId("_axXO19p-Ed-ak6NoX_4Aeg_1703334298")]
    [Description(@"Document is a debit note for the final amount settled for a commercial transaction.")]
    DebitNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as "CommercialInvoice".
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_axXO2Np-Ed-ak6NoX_4Aeg_1703334299")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice,
    
    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as "CreditNote".
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_axg_0Np-Ed-ak6NoX_4Aeg_1703334307")]
    [Description(@"Document is a credit note.")]
    CreditNote,
    
    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as "DebitNote".
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_axg_0dp-Ed-ak6NoX_4Aeg_1703334308")]
    [Description(@"Document is a debit note.")]
    DebitNote,
    
    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as "HireInvoice".
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_axg_0tp-Ed-ak6NoX_4Aeg_1703334309")]
    [Description(@"Document is an invoice for the hiring of human resources or renting goods or equipment.")]
    HireInvoice,
    
    /// <summary>
    /// Document is an invoice issued by the debtor.
    /// Encoded/decoded by serializers as "SelfBilledInvoice".
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_axg_09p-Ed-ak6NoX_4Aeg_1703334310")]
    [Description(@"Document is an invoice issued by the debtor.")]
    SelfBilledInvoice,
    
    /// <summary>
    /// Document is a remittance advice sent separately from the current transaction.
    /// Encoded/decoded by serializers as "RemittanceAdviceMessage".
    /// </summary>
    [EnumMember(Value = "RADM")]
    [IsoId("_axg_1Np-Ed-ak6NoX_4Aeg_1703334311")]
    [Description(@"Document is a remittance advice sent separately from the current transaction.")]
    RemittanceAdviceMessage,
    
    /// <summary>
    /// Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.
    /// Encoded/decoded by serializers as "RelatedPaymentInstruction".
    /// </summary>
    [EnumMember(Value = "RPIN")]
    [IsoId("_axg_1dp-Ed-ak6NoX_4Aeg_1703334312")]
    [Description(@"Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.")]
    RelatedPaymentInstruction,
    
    /// <summary>
    /// Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
    /// Encoded/decoded by serializers as "CommercialContract".
    /// </summary>
    [EnumMember(Value = "CMCN")]
    [IsoId("_axg_1tp-Ed-ak6NoX_4Aeg_1703334569")]
    [Description(@"Document is an agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.")]
    CommercialContract,
    
    /// <summary>
    /// Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers.
    /// Encoded/decoded by serializers as "ForeignExchangeDealReference".
    /// </summary>
    [EnumMember(Value = "FXDR")]
    [IsoId("_axg_19p-Ed-ak6NoX_4Aeg_1703334570")]
    [Description(@"Document is a pre-agreed or pre-arranged foreign exchange transaction to which the payment transaction refers.")]
    ForeignExchangeDealReference,
    
    /// <summary>
    /// Document is a statement of the transactions posted to the debtor's account at the supplier.
    /// Encoded/decoded by serializers as "StatementOfAccount".
    /// </summary>
    [EnumMember(Value = "SOAC")]
    [IsoId("_axg_2Np-Ed-ak6NoX_4Aeg_1703334571")]
    [Description(@"Document is a statement of the transactions posted to the debtor's account at the supplier.")]
    StatementOfAccount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DocumentType1CodeMetadataExtensions
{
    private static readonly DocumentType1CodeDropdownSource _dropdownSource = new DocumentType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDocumentType1CodeDropdownRow GetMetadata(this DocumentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


