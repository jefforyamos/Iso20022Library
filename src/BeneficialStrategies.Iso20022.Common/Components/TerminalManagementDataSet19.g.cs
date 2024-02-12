﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalManagementDataSet19.  ISO2002 ID# _oaQqsY32EeWRwov1g9WL_A.
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
/// Data set containing the acceptor parameters of a point of interaction (POI).
/// </summary>
[IsoId("_oaQqsY32EeWRwov1g9WL_A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Terminal Management Data Set")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TerminalManagementDataSet19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TerminalManagementDataSet19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TerminalManagementDataSet19( DataSetIdentification6 reqIdentification,AcceptorConfigurationContent5 reqContent )
    {
        Identification = reqIdentification;
        Content = reqContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_omxcsY32EeWRwov1g9WL_A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification6 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DataSetIdentification6 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification6 Identification { get; init; } 
    #else
    public DataSetIdentification6 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_omxcs432EeWRwov1g9WL_A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sequence Counter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax9NumericText? SequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceCounter { get; init; } 
    #else
    public System.String? SequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the point of interactions involved by the configuration data set.
    /// </summary>
    [IsoId("_0ypuQI33EeWRwov1g9WL_A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("POI Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification71? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification71? POIIdentification { get; init; } 
    #else
    public GenericIdentification71? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_rhj9YI33EeWRwov1g9WL_A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Configuration Scope")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType15Code? ConfigurationScope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType15Code? ConfigurationScope { get; init; } 
    #else
    public PartyType15Code? ConfigurationScope { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the acceptor parameters.
    /// </summary>
    [IsoId("_omxctY32EeWRwov1g9WL_A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Content")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorConfigurationContent5 Content { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AcceptorConfigurationContent5 Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorConfigurationContent5 Content { get; init; } 
    #else
    public AcceptorConfigurationContent5 Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
