﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorConfigurationDataSet1.  ISO2002 ID# _xqgssAueEeqw5uEXxQ9H4g.
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
[IsoId("_xqgssAueEeqw5uEXxQ9H4g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Acceptor Configuration Data Set")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorConfigurationDataSet1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorConfigurationDataSet1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorConfigurationDataSet1( DataSetIdentification8 reqIdentification,AcceptorConfigurationContent9 reqContent )
    {
        Identification = reqIdentification;
        Content = reqContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the data set transferred.
    /// </summary>
    [IsoId("_xqgssgueEeqw5uEXxQ9H4g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DataSetIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification8 Identification { get; init; } 
    #else
    public DataSetIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Counter to identify a single data set within the whole transfer.
    /// </summary>
    [IsoId("_xqgsswueEeqw5uEXxQ9H4g")]
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
    [IsoId("_xqgssQueEeqw5uEXxQ9H4g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("POI Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification176? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176? POIIdentification { get; init; } 
    #else
    public GenericIdentification176? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Scope of the configuration contained in the data set.
    /// </summary>
    [IsoId("_xqgstAueEeqw5uEXxQ9H4g")]
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
    [IsoId("_xqgstQueEeqw5uEXxQ9H4g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Content")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorConfigurationContent9 Content { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AcceptorConfigurationContent9 Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorConfigurationContent9 Content { get; init; } 
    #else
    public AcceptorConfigurationContent9 Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
