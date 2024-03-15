﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityParameters13.  ISO2002 ID# _iymGQS8iEeu125Ip9zFcsQ.
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
/// Parameters related to the security of software application and application protocol.
/// </summary>
[IsoId("_iymGQS8iEeu125Ip9zFcsQ")]
[DisplayName("Security Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityParameters13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityParameters13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityParameters13( TerminalManagementAction3Code reqActionType,System.String reqVersion )
    {
        ActionType = reqActionType;
        Version = reqVersion;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_jBon0S8iEeu125Ip9zFcsQ")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementAction3Code ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementAction3Code ActionType { get; init; } 
    #else
    public TerminalManagementAction3Code ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the security parameters.
    /// </summary>
    [IsoId("_jBon0y8iEeu125Ip9zFcsQ")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Version { get; init; } 
    #else
    public System.String Version { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_jBon1S8iEeu125Ip9zFcsQ")]
    [DisplayName("POI Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIChllng")]
    #endif
    [IsoXmlTag("POIChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? POIChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? POIChallenge { get; init; } 
    #else
    public System.Byte[]? POIChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_jBon1y8iEeu125Ip9zFcsQ")]
    [DisplayName("TM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMChllng")]
    #endif
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? TMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TMChallenge { get; init; } 
    #else
    public System.Byte[]? TMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Key to inject in the point of interaction, protected by the temporary key previously sent.
    /// </summary>
    [IsoId("_jBon2S8iEeu125Ip9zFcsQ")]
    [DisplayName("Security Element")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyElmt")]
    #endif
    [IsoXmlTag("SctyElmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKey15? SecurityElement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKey15? SecurityElement { get; init; } 
    #else
    public CryptographicKey15? SecurityElement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
