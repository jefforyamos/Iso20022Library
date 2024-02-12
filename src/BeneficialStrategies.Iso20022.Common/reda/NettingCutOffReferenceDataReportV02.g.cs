﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for NettingCutOffReferenceDataReportV02.  ISO2002 ID# _kBNoCQM-Ee2nqoJcXIhTdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.061.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Netting Cut Off Reference Data Report message is sent to a participant by a central system to provide details of scheduled, changed, existing and previous netting cut off data held at a central system.
/// </summary>
[Description(@"The Netting Cut Off Reference Data Report message is sent to a participant by a central system to provide details of scheduled, changed, existing and previous netting cut off data held at a central system.")]
[IsoId("_kBNoCQM-Ee2nqoJcXIhTdw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Netting Cut Off Reference Data Report V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NettingCutOffReferenceDataReportV02 : IOuterRecord<NettingCutOffReferenceDataReportV02,NettingCutOffReferenceDataReportV02Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.061.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetgCutOffRefDataRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => NettingCutOffReferenceDataReportV02Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NettingCutOffReferenceDataReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NettingCutOffReferenceDataReportV02( NettingCutOffReportData2 reqReportData,CutOffData2 reqParticipantNettingCutOffData )
    {
        ReportData = reqReportData;
        ParticipantNettingCutOffData = reqParticipantNettingCutOffData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the meta data for the netting cut off report including message pagination.
    /// </summary>
    [IsoId("_kBNoCwM-Ee2nqoJcXIhTdw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Report Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NettingCutOffReportData2 ReportData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public NettingCutOffReportData2 ReportData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingCutOffReportData2 ReportData { get; init; } 
    #else
    public NettingCutOffReportData2 ReportData { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the latest information related to the status of a netting cut off held at a central system.
    /// </summary>
    [IsoId("_kBNoDQM-Ee2nqoJcXIhTdw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Participant Netting Cut Off Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CutOffData2 ParticipantNettingCutOffData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CutOffData2 ParticipantNettingCutOffData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CutOffData2 ParticipantNettingCutOffData { get; init; } 
    #else
    public CutOffData2 ParticipantNettingCutOffData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kBNoDwM-Ee2nqoJcXIhTdw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="NettingCutOffReferenceDataReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public NettingCutOffReferenceDataReportV02Document ToDocument()
    {
        return new NettingCutOffReferenceDataReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="NettingCutOffReferenceDataReportV02"/>.
/// </summary>
[Serializable]
public partial record NettingCutOffReferenceDataReportV02Document : IOuterDocument<NettingCutOffReferenceDataReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.061.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="NettingCutOffReferenceDataReportV02"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NettingCutOffReferenceDataReportV02 Message { get; init; }
    #else
    public NettingCutOffReferenceDataReportV02 Message { get; init; }
    #endif
}
