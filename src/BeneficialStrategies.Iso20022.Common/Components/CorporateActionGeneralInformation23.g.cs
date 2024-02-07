﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation23.  ISO2002 ID# _eHGMoeaUEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General information about the corporate action event.
/// </summary>
public partial record CorporateActionGeneralInformation23
     : IIsoXmlSerilizable<CorporateActionGeneralInformation23>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public required IsoMax35Text CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    public IsoMax35Text? ClassActionNumber { get; init; } 
    /// <summary>
    /// Type of processing involved by a corporate action.
    /// </summary>
    public CorporateActionEventProcessingTypeChoice_? EventProcessingType { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required CorporateActionEventType3Choice_ EventType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    public required CorporateActionMandatoryVoluntary1Choice_ MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Indicates whether the message is related to a claim on the associated corporate action event.
    /// </summary>
    public AdditionalBusinessProcessFormat2Choice_? AdditionalBusinessProcessIndicator { get; init; } 
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    public required FinancialInstrumentAttributes19 UnderlyingSecurity { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(CorporateActionEventIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (OfficialCorporateActionEventIdentification is IsoMax35Text OfficialCorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "OffclCorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OfficialCorporateActionEventIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClassActionNumber is IsoMax35Text ClassActionNumberValue)
        {
            writer.WriteStartElement(null, "ClssActnNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClassActionNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (EventProcessingType is CorporateActionEventProcessingTypeChoice_ EventProcessingTypeValue)
        {
            writer.WriteStartElement(null, "EvtPrcgTp", xmlNamespace );
            EventProcessingTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EvtTp", xmlNamespace );
        EventType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MndtryVlntryEvtTp", xmlNamespace );
        MandatoryVoluntaryEventType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalBusinessProcessIndicator is AdditionalBusinessProcessFormat2Choice_ AdditionalBusinessProcessIndicatorValue)
        {
            writer.WriteStartElement(null, "AddtlBizPrcInd", xmlNamespace );
            AdditionalBusinessProcessIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UndrlygScty", xmlNamespace );
        UnderlyingSecurity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CorporateActionGeneralInformation23 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
