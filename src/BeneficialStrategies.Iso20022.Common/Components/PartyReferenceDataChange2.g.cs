﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyReferenceDataChange2.  ISO2002 ID# _70efBVhLEeih3fUfzR38Ig.
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
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
[IsoId("_70efBVhLEeih3fUfzR38Ig")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Party Reference Data Change")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyReferenceDataChange2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyReferenceDataChange2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyReferenceDataChange2( SystemPartyIdentification8 reqPartyIdentification,System.DateTime reqOperationTimeStamp )
    {
        PartyIdentification = reqPartyIdentification;
        OperationTimeStamp = reqOperationTimeStamp;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the party for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_7_fcMVhLEeih3fUfzR38Ig")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification8 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SystemPartyIdentification8 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification8 PartyIdentification { get; init; } 
    #else
    public SystemPartyIdentification8 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the party data record for which details of the change are provided.
    /// </summary>
    [IsoId("_E_5woIp8EeiEt5E1WBt_2Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Record")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public UpdateLogPartyRecord1Choice_? Record { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _E_5woIp8EeiEt5E1WBt_2Q
    
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_7_fcOVhLEeih3fUfzR38Ig")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Operation Time Stamp")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime OperationTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime OperationTimeStamp { get; init; } 
    #else
    public System.DateTime OperationTimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
