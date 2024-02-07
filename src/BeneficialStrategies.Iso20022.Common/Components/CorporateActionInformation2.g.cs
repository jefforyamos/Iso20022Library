﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionInformation2.  ISO2002 ID# _Td6PVdp-Ed-ak6NoX_4Aeg_2005876121.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateActionInformation2
     : IIsoXmlSerilizable<CorporateActionInformation2>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the issuer's agent or the issuer.
    /// </summary>
    public required PartyIdentification2Choice_ AgentIdentification { get; init; } 
    /// <summary>
    /// Reference given to the event by the CA event issuer (agent).
    /// </summary>
    public required IsoMax35Text IssuerCorporateActionIdentification { get; init; } 
    /// <summary>
    /// Reference assigned by the (I)CSD to unambiguously identify a corporate avent.
    /// </summary>
    public IsoMax35Text? CorporateActionProcessingIdentification { get; init; } 
    /// <summary>
    /// Speficies the type of corporate event.
    /// </summary>
    public required CorporateActionEventType2FormatChoice_ EventType { get; init; } 
    /// <summary>
    /// Type of processing involved by a Corporate Action.
    /// </summary>
    public CorporateActionEventProcessingType1FormatChoice_? EventProcessingType { get; init; } 
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    public required CorporateActionMandatoryVoluntary1FormatChoice_ MandatoryVoluntaryEventType { get; init; } 
    /// <summary>
    /// Identification of the underlying financial instrument, ie, the financial instrument affected by the corporate action event.
    /// </summary>
    public required FinancialInstrumentDescription3 UnderlyingSecurity { get; init; } 
    /// <summary>
    /// Identification of the secondary underlying financial instrument, ie, the non-principal financial instrument affected by the corporate action event.
    /// </summary>
    public FinancialInstrumentDescription3? OtherUnderlyingSecurity { get; init; } 
    
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
        writer.WriteStartElement(null, "AgtId", xmlNamespace );
        AgentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IssrCorpActnId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerCorporateActionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (CorporateActionProcessingIdentification is IsoMax35Text CorporateActionProcessingIdentificationValue)
        {
            writer.WriteStartElement(null, "CorpActnPrcgId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CorporateActionProcessingIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EvtTp", xmlNamespace );
        EventType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (EventProcessingType is CorporateActionEventProcessingType1FormatChoice_ EventProcessingTypeValue)
        {
            writer.WriteStartElement(null, "EvtPrcgTp", xmlNamespace );
            EventProcessingTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MndtryVlntryEvtTp", xmlNamespace );
        MandatoryVoluntaryEventType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UndrlygScty", xmlNamespace );
        UnderlyingSecurity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OtherUnderlyingSecurity is FinancialInstrumentDescription3 OtherUnderlyingSecurityValue)
        {
            writer.WriteStartElement(null, "OthrUndrlygScty", xmlNamespace );
            OtherUnderlyingSecurityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionInformation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
