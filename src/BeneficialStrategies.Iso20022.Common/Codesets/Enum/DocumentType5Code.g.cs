﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DocumentType5Code.  ISO2002 ID# _agObiNp-Ed-ak6NoX_4Aeg_1566612187.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_agObiNp-Ed-ak6NoX_4Aeg_1566612187")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
public enum DocumentType5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MeteredServiceInvoice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMgNp-Ed-ak6NoX_4Aeg_1566612217")]
    [Description(@"??")]
    MeteredServiceInvoice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditNoteRelatedToFinancialAdjustment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMgdp-Ed-ak6NoX_4Aeg_1566612248")]
    [Description(@"??")]
    CreditNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DebitNoteRelatedToFinancialAdjustment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMgtp-Ed-ak6NoX_4Aeg_1566612249")]
    [Description(@"??")]
    DebitNoteRelatedToFinancialAdjustment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommercialInvoice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMg9p-Ed-ak6NoX_4Aeg_1566612526")]
    [Description(@"??")]
    CommercialInvoice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CreditNote".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMhNp-Ed-ak6NoX_4Aeg_1566612557")]
    [Description(@"??")]
    CreditNote,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DebitNote".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMhdp-Ed-ak6NoX_4Aeg_1566612588")]
    [Description(@"??")]
    DebitNote,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HireInvoice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMhtp-Ed-ak6NoX_4Aeg_1566612618")]
    [Description(@"??")]
    HireInvoice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SelfBilledInvoice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMh9p-Ed-ak6NoX_4Aeg_1566612649")]
    [Description(@"??")]
    SelfBilledInvoice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CommercialContract".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMiNp-Ed-ak6NoX_4Aeg_1566612680")]
    [Description(@"??")]
    CommercialContract,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StatementOfAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_agYMidp-Ed-ak6NoX_4Aeg_1566612681")]
    [Description(@"??")]
    StatementOfAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DispatchAdvice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aghWcNp-Ed-ak6NoX_4Aeg_1566612710")]
    [Description(@"??")]
    DispatchAdvice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BillOfLading".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aghWcdp-Ed-ak6NoX_4Aeg_2010826154")]
    [Description(@"??")]
    BillOfLading,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Voucher".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aghWctp-Ed-ak6NoX_4Aeg_2027448669")]
    [Description(@"??")]
    Voucher,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountReceivableOpenItem".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aghWc9p-Ed-ak6NoX_4Aeg_2039452669")]
    [Description(@"??")]
    AccountReceivableOpenItem,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TradeServicesUtilityTransaction".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aghWdNp-Ed-ak6NoX_4Aeg_1739893330")]
    [Description(@"??")]
    TradeServicesUtilityTransaction,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DocumentType5CodeMetadataExtensions
{
    private static readonly DocumentType5CodeDropdownSource _dropdownSource = new DocumentType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDocumentType5CodeDropdownRow GetMetadata(this DocumentType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

