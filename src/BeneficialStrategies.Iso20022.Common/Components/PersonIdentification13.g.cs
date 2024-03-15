﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PersonIdentification13.  ISO2002 ID# _jJrTQa9UEeeJJK1oRb-jTw.
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
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_jJrTQa9UEeeJJK1oRb-jTw")]
[DisplayName("Person Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PersonIdentification13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_jU7hA69UEeeJJK1oRb-jTw")]
    [DisplayName("Date And Place Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndPlcOfBirth")]
    #endif
    [IsoXmlTag("DtAndPlcOfBirth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; } 
    #else
    public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_jU7hBa9UEeeJJK1oRb-jTw")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericPersonIdentification1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericPersonIdentification1? Other { get; init; } 
    #else
    public GenericPersonIdentification1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
