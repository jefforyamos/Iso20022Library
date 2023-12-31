﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesEntryTypeCode.  ISO2002 ID# _ZFLZ2Np-Ed-ak6NoX_4Aeg_1201325476.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities entry on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFLZ2Np-Ed-ak6NoX_4Aeg_1201325476")]
[Description(@"Specifies the type of securities entry on an account.")]
[Derivations(typeof(SecuritiesEntryType1Code),typeof(SecuritiesEntryType2Code),typeof(SecuritiesEntryType3Code))]
// External derivations that should be provided by the proper interface are: 
public enum SecuritiesEntryTypeCode
{
    /// <summary>
    /// Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as "BLOK".
    /// </summary>
    [EnumMember(Value = "BLOK")]
    [IsoId("_ZFLZ2dp-Ed-ak6NoX_4Aeg_1484848859")]
    [Description(@"Balance of securities that are blocked or frozen. A financial instrument may be unavailable due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.")]
    Blocked,
    
    /// <summary>
    /// Balance of securities that have been borrowed from another party.
    /// Encoded/decoded by serializers as "BORR".
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_ZFVK0Np-Ed-ak6NoX_4Aeg_1484849383")]
    [Description(@"Balance of securities that have been borrowed from another party.")]
    Borrowed,
    
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// Encoded/decoded by serializers as "COLI".
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("_ZFVK0dp-Ed-ak6NoX_4Aeg_1484849426")]
    [Description(@"Balance of securities that belong to a third party and that are held for the purpose of collateralisation.")]
    CollateralIn,
    
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// Encoded/decoded by serializers as "COLO".
    /// </summary>
    [EnumMember(Value = "COLO")]
    [IsoId("_ZFVK0tp-Ed-ak6NoX_4Aeg_1484849443")]
    [Description(@"Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.")]
    CollateralOut,
    
    /// <summary>
    /// Balance of securities that have been loaned to a third party.
    /// Encoded/decoded by serializers as "LOAN".
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_ZFVK09p-Ed-ak6NoX_4Aeg_1484849478")]
    [Description(@"Balance of securities that have been loaned to a third party.")]
    OnLoan,
    
    /// <summary>
    /// Balance of securities that are pending delivery.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZFVK1Np-Ed-ak6NoX_4Aeg_1485770002")]
    [Description(@"Balance of securities that are pending delivery.")]
    PendingDelivery,
    
    /// <summary>
    /// Balance of securities that are pending receipt.
    /// Encoded/decoded by serializers as "PENR".
    /// </summary>
    [EnumMember(Value = "PENR")]
    [IsoId("_ZFVK1dp-Ed-ak6NoX_4Aeg_1485770072")]
    [Description(@"Balance of securities that are pending receipt.")]
    PendingReceipt,
    
    /// <summary>
    /// Balance of securities that are pledged, for example, a financial instrument is unavailable because it has been used or given as a guarantee.
    /// Encoded/decoded by serializers as "PLED".
    /// </summary>
    [EnumMember(Value = "PLED")]
    [IsoId("_ZFVK1tp-Ed-ak6NoX_4Aeg_1485770114")]
    [Description(@"Balance of securities that are pledged, for example, a financial instrument is unavailable because it has been used or given as a guarantee.")]
    Pledged,
    
    /// <summary>
    /// Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled.
    /// Encoded/decoded by serializers as "REGO".
    /// </summary>
    [EnumMember(Value = "REGO")]
    [IsoId("_ZFVK19p-Ed-ak6NoX_4Aeg_1485770132")]
    [Description(@"Balance of securities currently being processed by the institution responsible for registering the new beneficial owner (or nominee) of securities after a transaction has settled.")]
    OutForRegistration,
    
    /// <summary>
    /// Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ZFVK2Np-Ed-ak6NoX_4Aeg_1485770469")]
    [Description(@"Balance of securities that is unclassified, ie, is not identified with one of the existing sub-balance types.")]
    Unclassified,
    
    /// <summary>
    /// Balance of physical securities that are in transshipment, eg, in the process of being transferred from one depository or agent to another.
    /// Encoded/decoded by serializers as "TRAN".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZFVK2dp-Ed-ak6NoX_4Aeg_1485770529")]
    [Description(@"Balance of physical securities that are in transshipment, eg, in the process of being transferred from one depository or agent to another.")]
    InTransshipment,
    
    /// <summary>
    /// Total number of securities eligible for this event.
    /// Encoded/decoded by serializers as "ELIG".
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ZFeUwNp-Ed-ak6NoX_4Aeg_69749516")]
    [Description(@"Total number of securities eligible for this event.")]
    Eligible,
    
    /// <summary>
    /// Balance of securities that are registered (in the name of a nominee or of the beneficial owner).
    /// Encoded/decoded by serializers as "NOMI".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_ZFeUwdp-Ed-ak6NoX_4Aeg_1485771027")]
    [Description(@"Balance of securities that are registered (in the name of a nominee or of the beneficial owner).")]
    Registered,
    
    /// <summary>
    /// Balance of securities that remain registered in the name of the prior beneficial owner of securities.
    /// Encoded/decoded by serializers as "SPOS".
    /// </summary>
    [EnumMember(Value = "SPOS")]
    [IsoId("_ZFeUwtp-Ed-ak6NoX_4Aeg_1485771062")]
    [Description(@"Balance of securities that remain registered in the name of the prior beneficial owner of securities.")]
    StreetPosition,
    
    /// <summary>
    /// Balance of securities that could not be registered due to foreign ownership limitation.
    /// Encoded/decoded by serializers as "UNRG".
    /// </summary>
    [EnumMember(Value = "UNRG")]
    [IsoId("_ZFeUw9p-Ed-ak6NoX_4Aeg_1485771356")]
    [Description(@"Balance of securities that could not be registered due to foreign ownership limitation.")]
    Unregistered,
    
    /// <summary>
    /// Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.
    /// Encoded/decoded by serializers as "WDOC".
    /// </summary>
    [EnumMember(Value = "WDOC")]
    [IsoId("_ZFeUxNp-Ed-ak6NoX_4Aeg_1485771374")]
    [Description(@"Financial instrument is unavailable due to missing or incomplete documentation pertaining to the account, or due to a missing or incomplete order.")]
    WaitingDocumentation,
    
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// Encoded/decoded by serializers as "SETT".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_ZFeUxdp-Ed-ak6NoX_4Aeg_192376952")]
    [Description(@"Balance of securities representing only settled transactions; pending transactions not included.")]
    SettlementPosition,
    
    /// <summary>
    /// Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register.
    /// Encoded/decoded by serializers as "BTRA".
    /// </summary>
    [EnumMember(Value = "BTRA")]
    [IsoId("_ZFeUxtp-Ed-ak6NoX_4Aeg_-1524450363")]
    [Description(@"Financial instrument is unavailable as a result of a transfer order, pending movement in the shareholders' register.")]
    BeingTransferred,
    
    /// <summary>
    /// Balance of securities representing only settled transactions.
    /// Encoded/decoded by serializers as "SETD".
    /// </summary>
    [EnumMember(Value = "SETD")]
    [IsoId("_ZFeUx9p-Ed-ak6NoX_4Aeg_1818454189")]
    [Description(@"Balance of securities representing only settled transactions.")]
    Settled,
    
    /// <summary>
    /// Balance of securities representing traded transactions.
    /// Encoded/decoded by serializers as "TRAD".
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZFeUyNp-Ed-ak6NoX_4Aeg_-2044304370")]
    [Description(@"Balance of securities representing traded transactions.")]
    Traded,
    
    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as "UNBA".
    /// </summary>
    [EnumMember(Value = "UNBA")]
    [IsoId("_ZFeUydp-Ed-ak6NoX_4Aeg_-1599881363")]
    [Description(@"Balance of uninstructed position.")]
    UninstructedBalance,
    
    /// <summary>
    /// Balance of instructed position.
    /// Encoded/decoded by serializers as "INBA".
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_ZFoFwNp-Ed-ak6NoX_4Aeg_-1589721161")]
    [Description(@"Balance of instructed position.")]
    InstructedBalance,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesEntryTypeCodeMetadataExtensions
{
    private static readonly SecuritiesEntryTypeCodeDropdownSource _dropdownSource = new SecuritiesEntryTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesEntryTypeCodeDropdownRow GetMetadata(this SecuritiesEntryTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


