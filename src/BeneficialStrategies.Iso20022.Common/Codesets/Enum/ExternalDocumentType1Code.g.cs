﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalDocumentType1Code.  ISO2002 ID# _TRd1lQEcEeCQm6a_G2yO_w_-2000804231.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the document type as published in an external document type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TRd1lQEcEeCQm6a_G2yO_w_-2000804231")]
[Description(@"Specifies the document type as published in an external document type code list. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDocumentTypeCode))]
public enum ExternalDocumentType1Code
{
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as "CommercialInvoice".
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_uHPTdfRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice,
    
    /// <summary>
    /// Document is a credit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as "CreditNoteRelatedToFinancialAdjustment".
    /// </summary>
    [EnumMember(Value = "CNFA")]
    [IsoId("_uHPTePRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a credit note for the final amount settled for a commercial transaction.")]
    CreditNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// Document is a contract evidencing an agreement between the seller and buyer for the supply of goods and/or services.
    /// Encoded/decoded by serializers as "Contract".
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_uHZEcvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a contract evidencing an agreement between the seller and buyer for the supply of goods and/or services.")]
    Contract,
    
    /// <summary>
    /// Document is a credit note.
    /// Encoded/decoded by serializers as "CreditNote".
    /// </summary>
    [EnumMember(Value = "CREN")]
    [IsoId("_uHZEdfRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a credit note.")]
    CreditNote,
    
    /// <summary>
    /// Document is a debit note.
    /// Encoded/decoded by serializers as "DebitNote".
    /// </summary>
    [EnumMember(Value = "DEBN")]
    [IsoId("_uHZEePRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a debit note.")]
    DebitNote,
    
    /// <summary>
    /// Document is an advice of despatch of the goods.
    /// Encoded/decoded by serializers as "DispatchAdvice".
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_uHZEe_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is an advice of despatch of the goods.")]
    DispatchAdvice,
    
    /// <summary>
    /// Document is a debit note for the final amount settled for a commercial transaction.
    /// Encoded/decoded by serializers as "DebitNoteRelatedToFinancialAdjustment".
    /// </summary>
    [EnumMember(Value = "DNFA")]
    [IsoId("_uHZEfvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a debit note for the final amount settled for a commercial transaction.")]
    DebitNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// Document is an invoice for the hiring of human resources or renting goods or equipment.
    /// Encoded/decoded by serializers as "HireInvoice".
    /// </summary>
    [EnumMember(Value = "HIRI")]
    [IsoId("_uHiOYvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice for the hiring of human resources or renting goods or equipment.")]
    HireInvoice,
    
    /// <summary>
    /// Document is a signed invoice.
    /// Encoded/decoded by serializers as "InvoiceSigned".
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_uHiOZfRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a signed invoice.")]
    InvoiceSigned,
    
    /// <summary>
    /// Document is an invoice claiming payment for the supply of metered services, eg. Gas or electricity, supplied to a fixed meter.
    /// Encoded/decoded by serializers as "MeteredServiceInvoice".
    /// </summary>
    [EnumMember(Value = "MSIN")]
    [IsoId("_uHiOaPRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice claiming payment for the supply of metered services, eg. Gas or electricity, supplied to a fixed meter.")]
    MeteredServiceInvoice,
    
    /// <summary>
    /// In trade transactions, a pro forma invoice is a document that states a commitment from the seller to sell goods to the buyer at specified prices and terms. It is used to declare the value of the trade. It is not a true invoice, because it is not used to record accounts receivable for the seller and accounts payable for the buyer.
    /// Encoded/decoded by serializers as "ProformaInvoice".
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_uHiOa_RYEeuLhpyIdtJzwg")]
    [Description(@"In trade transactions, a pro forma invoice is a document that states a commitment from the seller to sell goods to the buyer at specified prices and terms. It is used to declare the value of the trade. It is not a true invoice, because it is not used to record accounts receivable for the seller and accounts payable for the buyer.")]
    ProformaInvoice,
    
    /// <summary>
    /// Document is a purchase order.
    /// Encoded/decoded by serializers as "PurchaseOrder".
    /// </summary>
    [EnumMember(Value = "PUOR")]
    [IsoId("_uHiObvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a purchase order.")]
    PurchaseOrder,
    
    /// <summary>
    /// Document is a quotation setting out the conditions under which the goods and/or services are offered.
    /// Encoded/decoded by serializers as "Quotation".
    /// </summary>
    [EnumMember(Value = "QUOT")]
    [IsoId("_uHr_YvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a quotation setting out the conditions under which the goods and/or services are offered.")]
    Quotation,
    
    /// <summary>
    /// Document is a statement of the transactions posted to the debtor's account at the supplier.
    /// Encoded/decoded by serializers as "SelfBilledInvoice".
    /// </summary>
    [EnumMember(Value = "SBIN")]
    [IsoId("_uHr_ZfRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a statement of the transactions posted to the debtor's account at the supplier.")]
    SelfBilledInvoice,
    
    /// <summary>
    /// Document is a document presented by the seller in support of the procurement of goods and/or services.
    /// Encoded/decoded by serializers as "SellerPresentment".
    /// </summary>
    [EnumMember(Value = "SPRR")]
    [IsoId("_uH1JUvRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a document presented by the seller in support of the procurement of goods and/or services.")]
    SellerPresentment,
    
    /// <summary>
    /// Document is a timesheet recording times for the provision of services and/or delivery of goods.
    /// Encoded/decoded by serializers as "TimeSheet".
    /// </summary>
    [EnumMember(Value = "TISH")]
    [IsoId("_uH1JVfRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a timesheet recording times for the provision of services and/or delivery of goods.")]
    TimeSheet,
    
    /// <summary>
    /// Document is a usage report indicating the consumption pattern for designated goods and/or services.
    /// Encoded/decoded by serializers as "UsageReport".
    /// </summary>
    [EnumMember(Value = "USAR")]
    [IsoId("_uH1JWPRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a usage report indicating the consumption pattern for designated goods and/or services.")]
    UsageReport,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalDocumentType1CodeMetadataExtensions
{
    private static readonly ExternalDocumentType1CodeDropdownSource _dropdownSource = new ExternalDocumentType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalDocumentType1CodeDropdownRow GetMetadata(this ExternalDocumentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


