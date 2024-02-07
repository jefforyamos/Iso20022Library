﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SpecificInstructionRequest1.  ISO2002 ID# _RVH95Np-Ed-ak6NoX_4Aeg_-1758177157.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Request to execute specific instructions, such as participation registration, securities registration or blocking of securities.
/// </summary>
public partial record SpecificInstructionRequest1
     : IIsoXmlSerilizable<SpecificInstructionRequest1>
{
    #nullable enable
    
    /// <summary>
    /// Request to register for participation to the meeting.
    /// </summary>
    public IsoYesNoIndicator? ParticipationRegistration { get; init; } 
    /// <summary>
    /// Request to block the securities.
    /// </summary>
    public IsoYesNoIndicator? BlockingSecurities { get; init; } 
    /// <summary>
    /// Request to register the securities for the meeting.
    /// </summary>
    public IsoYesNoIndicator? SecuritiesRegistration { get; init; } 
    
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
        if (ParticipationRegistration is IsoYesNoIndicator ParticipationRegistrationValue)
        {
            writer.WriteStartElement(null, "PrtcptnRegn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ParticipationRegistrationValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (BlockingSecurities is IsoYesNoIndicator BlockingSecuritiesValue)
        {
            writer.WriteStartElement(null, "BlckgScties", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(BlockingSecuritiesValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (SecuritiesRegistration is IsoYesNoIndicator SecuritiesRegistrationValue)
        {
            writer.WriteStartElement(null, "SctiesRegn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SecuritiesRegistrationValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static SpecificInstructionRequest1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
