﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation150.  ISO2002 ID# _Ovm5JAVTEeqjd8n6wD9JVw.
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
public partial record CorporateActionGeneralInformation150
     : IIsoXmlSerilizable<CorporateActionGeneralInformation150>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public required IsoRestrictedFINXMax16Text CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    public IsoRestrictedFINXMax16Text? OfficialCorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClassActionNumber { get; init; } 
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    public required CorporateActionEventType97Choice_ EventType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    public required CorporateActionMandatoryVoluntary4Choice_ MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(CorporateActionEventIdentification)); // data type RestrictedFINXMax16Text System.String
        writer.WriteEndElement();
        if (OfficialCorporateActionEventIdentification is IsoRestrictedFINXMax16Text OfficialCorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "OffclCorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(OfficialCorporateActionEventIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClassActionNumber is IsoRestrictedFINXMax16Text ClassActionNumberValue)
        {
            writer.WriteStartElement(null, "ClssActnNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClassActionNumberValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EvtTp", xmlNamespace );
        EventType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MndtryVlntryEvtTp", xmlNamespace );
        MandatoryVoluntaryEventType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CorporateActionGeneralInformation150 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
