﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTerminalParameters7.  ISO2002 ID# _vrWb4QufEeqw5uEXxQ9H4g.
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
/// Manufacturer configuration parameters of the point of interaction (POI).
/// </summary>
[IsoId("_vrWb4QufEeqw5uEXxQ9H4g")]
[DisplayName("Payment Terminal Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTerminalParameters7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTerminalParameters7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTerminalParameters7( TerminalManagementAction3Code reqActionType )
    {
        ActionType = reqActionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_v1_loQufEeqw5uEXxQ9H4g")]
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
    /// Identification of the vendor for the MTM, if the POI manages various subsets of terminal parameters.
    /// </summary>
    [IsoId("_v1_lowufEeqw5uEXxQ9H4g")]
    [DisplayName("Vendor Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VndrId")]
    #endif
    [IsoXmlTag("VndrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? VendorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VendorIdentification { get; init; } 
    #else
    public System.String? VendorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the terminal parameters.
    /// </summary>
    [IsoId("_v1_lpQufEeqw5uEXxQ9H4g")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Version { get; init; } 
    #else
    public System.String? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the parameters&apos; format.
    /// </summary>
    [IsoId("_v1_lpwufEeqw5uEXxQ9H4g")]
    [DisplayName("Parameter Format Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParamFrmtIdr")]
    #endif
    [IsoXmlTag("ParamFrmtIdr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? ParameterFormatIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ParameterFormatIdentifier { get; init; } 
    #else
    public System.String? ParameterFormatIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_v1_lqQufEeqw5uEXxQ9H4g")]
    [DisplayName("Clock Synchronisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClckSynctn")]
    #endif
    [IsoXmlTag("ClckSynctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClockSynchronisation3? ClockSynchronisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClockSynchronisation3? ClockSynchronisation { get; init; } 
    #else
    public ClockSynchronisation3? ClockSynchronisation { get; set; } 
    #endif
    
    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_v1_lqwufEeqw5uEXxQ9H4g")]
    [DisplayName("Time Zone Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmZoneLine")]
    #endif
    [IsoXmlTag("TmZoneLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TimeZoneLine { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TimeZoneLine { get; init; } 
    #else
    public System.String? TimeZoneLine { get; set; } 
    #endif
    
    /// <summary>
    /// Local time offset to UTC (Coordinated Universal Time).
    /// </summary>
    [IsoId("_v1_lrQufEeqw5uEXxQ9H4g")]
    [DisplayName("Local Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclDtTm")]
    #endif
    [IsoXmlTag("LclDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalDateTime1? LocalDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalDateTime1? LocalDateTime { get; init; } 
    #else
    public LocalDateTime1? LocalDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Others manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_v1_lrwufEeqw5uEXxQ9H4g")]
    [DisplayName("Other Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrParams")]
    #endif
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? OtherParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? OtherParameters { get; init; } 
    #else
    public System.Byte[]? OtherParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
