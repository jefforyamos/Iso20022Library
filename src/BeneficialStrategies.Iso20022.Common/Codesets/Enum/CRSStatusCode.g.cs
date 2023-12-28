﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CRSStatusCode.  ISO2002 ID# _8_HBAENfEeaS-NnwLNvMPg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the Common Reporting Status (CRS) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8_HBAENfEeaS-NnwLNvMPg")]
[Description(@"Specifies the Common Reporting Status (CRS) status.")]
public enum CRSStatusCode
{
    /// <summary>
    /// Account holder type is a passive non-financial entity with one or more controlling persons that are foreign persons.
    /// Encoded/decoded by serializers as "C101".
    /// </summary>
    [EnumMember(Value = "C101")]
    [IsoId("_mTQdsENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a passive non-financial entity with one or more controlling persons that are foreign persons.")]
    CRS101,
    
    /// <summary>
    /// Account holder type is a foreign person.
    /// Encoded/decoded by serializers as "C102".
    /// </summary>
    [EnumMember(Value = "C102")]
    [IsoId("_qH2JoENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a foreign person.")]
    CRS102,
    
    /// <summary>
    /// Account holder type is a passive foreign non-financial entity without controlling persons that are foreign persons.
    /// Encoded/decoded by serializers as "C103".
    /// </summary>
    [EnumMember(Value = "C103")]
    [IsoId("_sSD-cENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a passive foreign non-financial entity without controlling persons that are foreign persons.")]
    CRS103,
    
    /// <summary>
    /// Account holder type is a financial institution such as a depositary, a custodial institution or a specified insurance company.
    /// Encoded/decoded by serializers as "C104".
    /// </summary>
    [EnumMember(Value = "C104")]
    [IsoId("_usWPkENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a financial institution such as a depositary, a custodial institution or a specified insurance company.")]
    CRS104,
    
    /// <summary>
    /// Account holder type is a financial institution such as an investment entity of a non-participating jurisdiction and managed by another financial institution without one or more controlling persons that are foreign persons.
    /// Encoded/decoded by serializers as "C105".
    /// </summary>
    [EnumMember(Value = "C105")]
    [IsoId("_w-458ENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a financial institution such as an investment entity of a non-participating jurisdiction and managed by another financial institution without one or more controlling persons that are foreign persons.")]
    CRS105,
    
    /// <summary>
    /// Account holder type is a financial institution such as an investment entity of a non-participating jurisdiction and managed by another financial institution with one or more controlling persons that are foreign persons.
    /// Encoded/decoded by serializers as "C106".
    /// </summary>
    [EnumMember(Value = "C106")]
    [IsoId("_zhNFsENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a financial institution such as an investment entity of a non-participating jurisdiction and managed by another financial institution with one or more controlling persons that are foreign persons.")]
    CRS106,
    
    /// <summary>
    /// Account holder type is a financial institution such as another investment entity.
    /// Encoded/decoded by serializers as "C107".
    /// </summary>
    [EnumMember(Value = "C107")]
    [IsoId("_1yHYYENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a financial institution such as another investment entity.")]
    CRS107,
    
    /// <summary>
    /// Account holder type is an active non-financial entity such as a corporation for which the stock is regularly traded on an established securities market.
    /// Encoded/decoded by serializers as "C108".
    /// </summary>
    [EnumMember(Value = "C108")]
    [IsoId("_4gMIMENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is an active non-financial entity such as a corporation for which the stock is regularly traded on an established securities market.")]
    CRS108,
    
    /// <summary>
    /// Account holder type is an active non-financial entity such as a corporation which is a related entity of a corporation for which the stock is regularly traded on an established securities market.
    /// Encoded/decoded by serializers as "C109".
    /// </summary>
    [EnumMember(Value = "C109")]
    [IsoId("_7bDW0ENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is an active non-financial entity such as a corporation which is a related entity of a corporation for which the stock is regularly traded on an established securities market.")]
    CRS109,
    
    /// <summary>
    /// Account holder type is an active non-financial entity such as a government entity.
    /// Encoded/decoded by serializers as "C110".
    /// </summary>
    [EnumMember(Value = "C110")]
    [IsoId("_99EnoENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is an active non-financial entity such as a government entity.")]
    CRS110,
    
    /// <summary>
    /// Account holder type is an active non-financial entity such as a central bank.
    /// Encoded/decoded by serializers as "C111".
    /// </summary>
    [EnumMember(Value = "C111")]
    [IsoId("_-ENxcENrEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is an active non-financial entity such as a central bank.")]
    CRS111,
    
    /// <summary>
    /// Account holder type is an active non-financial entity such as an international organisation.
    /// Encoded/decoded by serializers as "C112".
    /// </summary>
    [EnumMember(Value = "C112")]
    [IsoId("_CcziUENsEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is an active non-financial entity such as an international organisation.")]
    CRS112,
    
    /// <summary>
    /// Account holder type is not a foreign person.
    /// Encoded/decoded by serializers as "C113".
    /// </summary>
    [EnumMember(Value = "C113")]
    [IsoId("_CkGdIENsEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is not a foreign person.")]
    CRS113,
    
    /// <summary>
    /// Account holder type is a financial institution such as an investment entity of a participating jurisdiction and managed by another financial institution.
    /// Encoded/decoded by serializers as "C114".
    /// </summary>
    [EnumMember(Value = "C114")]
    [IsoId("_G_9kcENsEeaS-NnwLNvMPg")]
    [Description(@"Account holder type is a financial institution such as an investment entity of a participating jurisdiction and managed by another financial institution.")]
    CRS114,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CRSStatusCodeMetadataExtensions
{
    private static readonly CRSStatusCodeDropdownSource _dropdownSource = new CRSStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICRSStatusCodeDropdownRow GetMetadata(this CRSStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


