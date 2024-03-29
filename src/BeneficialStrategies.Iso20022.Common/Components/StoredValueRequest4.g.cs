﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StoredValueRequest4.  ISO2002 ID# _zsqYsS84Eeu125Ip9zFcsQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a Stored Value service (Prepaid card or account).
/// </summary>
[IsoId("_zsqYsS84Eeu125Ip9zFcsQ")]
[DisplayName("Stored Value Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StoredValueRequest4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [IsoId("_z5FrIS84Eeu125Ip9zFcsQ")]
    [DisplayName("Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Data")]
    #endif
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData4> Data { get; init; } = new ValueList<StoredValueData4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _z5FrIS84Eeu125Ip9zFcsQ
    
    
    #nullable disable
    
}
