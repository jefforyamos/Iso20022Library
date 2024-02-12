﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation136.  ISO2002 ID# _cw1I0-XmEemEj48jhmlA0Q.
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
/// General information about the corporate action event.
/// </summary>
[IsoId("_cw1I0-XmEemEj48jhmlA0Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action General Information")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionGeneralInformation136
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionGeneralInformation136 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionGeneralInformation136( System.String reqCorporateActionEventIdentification,CorporateActionEventType84Choice_ reqEventType,CorporateActionMandatoryVoluntary3Choice_ reqMandatoryVoluntaryEventType,FinancialInstrumentAttributes79 reqUnderlyingSecurity )
    {
        CorporateActionEventIdentification = reqCorporateActionEventIdentification;
        EventType = reqEventType;
        MandatoryVoluntaryEventType = reqMandatoryVoluntaryEventType;
        UnderlyingSecurity = reqUnderlyingSecurity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_dB8G5eXmEemEj48jhmlA0Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Action Event Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CorporateActionEventIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String CorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CorporateActionEventIdentification { get; init; } 
    #else
    public System.String CorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_dB8G7eXmEemEj48jhmlA0Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Official Corporate Action Event Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OfficialCorporateActionEventIdentification { get; init; } 
    #else
    public System.String? OfficialCorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_dB8G9eXmEemEj48jhmlA0Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Class Action Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClassActionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassActionNumber { get; init; } 
    #else
    public System.String? ClassActionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Type of processing involved by a corporate action.
    /// </summary>
    [IsoId("_dB8G_eXmEemEj48jhmlA0Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Event Processing Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventProcessingType2Choice_? EventProcessingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventProcessingType2Choice_? EventProcessingType { get; init; } 
    #else
    public CorporateActionEventProcessingType2Choice_? EventProcessingType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_dB8HBeXmEemEj48jhmlA0Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Event Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventType84Choice_ EventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CorporateActionEventType84Choice_ EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType84Choice_ EventType { get; init; } 
    #else
    public CorporateActionEventType84Choice_ EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_dCF35eXmEemEj48jhmlA0Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Mandatory Voluntary Event Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMandatoryVoluntary3Choice_ MandatoryVoluntaryEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CorporateActionMandatoryVoluntary3Choice_ MandatoryVoluntaryEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMandatoryVoluntary3Choice_ MandatoryVoluntaryEventType { get; init; } 
    #else
    public CorporateActionMandatoryVoluntary3Choice_ MandatoryVoluntaryEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_dCF37eXmEemEj48jhmlA0Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Underlying Security")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentAttributes79 UnderlyingSecurity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialInstrumentAttributes79 UnderlyingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes79 UnderlyingSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributes79 UnderlyingSecurity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
