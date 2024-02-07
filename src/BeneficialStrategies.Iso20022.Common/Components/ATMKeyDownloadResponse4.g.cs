﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMKeyDownloadResponse4.  ISO2002 ID# _Zt_VgbTyEeeQy4o2AayYHg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of an ATM key download from an ATM manager.
/// </summary>
public partial record ATMKeyDownloadResponse4
     : IIsoXmlSerilizable<ATMKeyDownloadResponse4>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    public required ATMEnvironment7 Environment { get; init; } 
    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    public required ATMSecurityContext3 ATMSecurityContext { get; init; } 
    /// <summary>
    /// Random value from the ATM provided during a previous exchange.
    /// </summary>
    public IsoMax140Binary? ATMChallenge { get; init; } 
    /// <summary>
    /// Security parameters of the host downloading the key.
    /// </summary>
    public required SecurityParameters10 HostSecurityParameters { get; init; } 
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    public ATMCommand13? Command { get; init; } 
    
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
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ATMSctyCntxt", xmlNamespace );
        ATMSecurityContext.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ATMChallenge is IsoMax140Binary ATMChallengeValue)
        {
            writer.WriteStartElement(null, "ATMChllng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Binary(ATMChallengeValue)); // data type Max140Binary System.Byte[]
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "HstSctyParams", xmlNamespace );
        HostSecurityParameters.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Command is ATMCommand13 CommandValue)
        {
            writer.WriteStartElement(null, "Cmd", xmlNamespace );
            CommandValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMKeyDownloadResponse4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
