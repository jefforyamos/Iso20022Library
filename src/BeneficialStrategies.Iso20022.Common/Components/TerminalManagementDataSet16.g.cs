﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TerminalManagementDataSet16.  ISO2002 ID# _gOilQY3cEeW32YMP0mBeyw.
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
/// Data related to the status report of a point of interaction (POI).
/// </summary>
[IsoId("_gOilQY3cEeW32YMP0mBeyw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Terminal Management Data Set")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TerminalManagementDataSet16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TerminalManagementDataSet16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TerminalManagementDataSet16( DataSetIdentification6 reqIdentification,StatusReportContent5 reqContent )
    {
        Identification = reqIdentification;
        Content = reqContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the data set containing the status report.
    /// </summary>
    [IsoId("_gawcUY3cEeW32YMP0mBeyw")]
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
    [IsoId("_gawcU43cEeW32YMP0mBeyw")]
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
    /// Content of the status report.
    /// </summary>
    [IsoId("_gawcVY3cEeW32YMP0mBeyw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Content")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatusReportContent5 Content { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public StatusReportContent5 Content { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReportContent5 Content { get; init; } 
    #else
    public StatusReportContent5 Content { get; set; } 
    #endif
    
    
    #nullable disable
    
}
