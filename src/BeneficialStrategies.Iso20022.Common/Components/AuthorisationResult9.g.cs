﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthorisationResult9.  ISO2002 ID# _TJtuMYp8EeS3NqNpgnMh2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the withdrawal authorisation.
/// </summary>
public partial record AuthorisationResult9
     : IIsoXmlSerilizable<AuthorisationResult9>
{
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    public PartyType13Code? AuthorisationEntity { get; init; } 
    /// <summary>
    /// Result of the authorisation.
    /// </summary>
    public required ResponseType3 AuthorisationResponse { get; init; } 
    /// <summary>
    /// Trace of response by the entities in the path from the issuer to the ATM.
    /// </summary>
    public ResponseType4? ResponseTrace { get; init; } 
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    public Action5? Action { get; init; } 
    
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
        if (AuthorisationEntity is PartyType13Code AuthorisationEntityValue)
        {
            writer.WriteStartElement(null, "AuthstnNtty", xmlNamespace );
            writer.WriteValue(AuthorisationEntityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AuthstnRspn", xmlNamespace );
        AuthorisationResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ResponseTrace is ResponseType4 ResponseTraceValue)
        {
            writer.WriteStartElement(null, "RspnTrac", xmlNamespace );
            ResponseTraceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AuthorisationCode is IsoMin6Max8Text AuthorisationCodeValue)
        {
            writer.WriteStartElement(null, "AuthstnCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMin6Max8Text(AuthorisationCodeValue)); // data type Min6Max8Text System.String
            writer.WriteEndElement();
        }
        if (Action is Action5 ActionValue)
        {
            writer.WriteStartElement(null, "Actn", xmlNamespace );
            ActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AuthorisationResult9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
