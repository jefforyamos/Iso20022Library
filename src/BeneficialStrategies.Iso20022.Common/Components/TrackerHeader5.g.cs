﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerHeader5.  ISO2002 ID# _MKVgwWRPEeqImsG9JNoSQw.
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
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_MKVgwWRPEeqImsG9JNoSQw")]
[DisplayName("Tracker Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerHeader5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerHeader5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerHeader5( System.String reqMessageIdentification )
    {
        MessageIdentification = reqMessageIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the tracker informing party and sent by the tracker to unambiguously identify the message.
    /// </summary>
    [IsoId("_MVIbgWRPEeqImsG9JNoSQw")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_MVIbg2RPEeqImsG9JNoSQw")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CreationDateTime { get; init; } 
    #else
    public System.DateTime? CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_MVIbhWRPEeqImsG9JNoSQw")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfTransactions { get; init; } 
    #else
    public System.String? NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Party that provides information on the status and related details of a transaction.
    /// </summary>
    [IsoId("_MVIbh2RPEeqImsG9JNoSQw")]
    [DisplayName("Tracker Informing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrInfrmgPty")]
    #endif
    [IsoXmlTag("TrckrInfrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; } 
    #else
    public TrackerPartyIdentification2? TrackerInformingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is updated on the status and related details of a transaction.
    /// </summary>
    [IsoId("_MVIbiWRPEeqImsG9JNoSQw")]
    [DisplayName("Tracker Informed Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrInfrmdPty")]
    #endif
    [IsoXmlTag("TrckrInfrmdPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; } 
    #else
    public TrackerPartyIdentification2? TrackerInformedParty { get; set; } 
    #endif
    
    /// <summary>
    /// Original reference, as assigned by the informer and sent to the tracker to unambiguously identify the tracker update message.
    /// Usage: this element may only be present when the alert notification is related to a payment status tracker update.
    /// </summary>
    [IsoId("_MVIbi2RPEeqImsG9JNoSQw")]
    [DisplayName("Original Tracker Update")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTrckrUpd")]
    #endif
    [IsoXmlTag("OrgnlTrckrUpd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalBusinessInstruction1? OriginalTrackerUpdate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalBusinessInstruction1? OriginalTrackerUpdate { get; init; } 
    #else
    public OriginalBusinessInstruction1? OriginalTrackerUpdate { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement under which or rules under which the tracker update should be processed.
    /// </summary>
    [IsoId("_MVIbjWRPEeqImsG9JNoSQw")]
    [DisplayName("Service Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvl")]
    #endif
    [IsoXmlTag("SvcLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #else
    public ServiceLevel8Choice_? ServiceLevel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
