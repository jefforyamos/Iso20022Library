﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PledgeeTypeAndAnyBICIdentifier2.  ISO2002 ID# _YxXJ0dLGEeiN28wlpBQScw.
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
/// Identification of the entity to which the financial instruments are pledged expressed as a code and a BIC.
/// </summary>
[IsoId("_YxXJ0dLGEeiN28wlpBQScw")]
[DisplayName("Pledgee Type And Any BIC Identifier")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PledgeeTypeAndAnyBICIdentifier2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PledgeeTypeAndAnyBICIdentifier2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PledgeeTypeAndAnyBICIdentifier2( System.String reqIdentification,PledgeeType1Code reqPledgeeType )
    {
        Identification = reqIdentification;
        PledgeeType = reqPledgeeType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the entity to which the financial instruments are pledged, expressed as a BIC.
    /// </summary>
    [IsoId("_ZF5PYdLGEeiN28wlpBQScw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICDec2014Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Entity to which the financial instruments are pledged expressed as a code.
    /// </summary>
    [IsoId("_ZF5PY9LGEeiN28wlpBQScw")]
    [DisplayName("Pledgee Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PldgeeTp")]
    #endif
    [IsoXmlTag("PldgeeTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PledgeeType1Code PledgeeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PledgeeType1Code PledgeeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PledgeeType1Code PledgeeType { get; init; } 
    #else
    public PledgeeType1Code PledgeeType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
