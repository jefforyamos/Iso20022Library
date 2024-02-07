﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amendment2.  ISO2002 ID# _9-Q1snltEeG7BsjMvd1mEw_-687774575.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
public partial record Amendment2
     : IIsoXmlSerilizable<Amendment2>
{
    #nullable enable
    
    /// <summary>
    /// Contents of the related Undertaking Amendment message.
    /// </summary>
    public required UndertakingAmendmentMessage1 UndertakingAmendmentMessage { get; init; } 
    /// <summary>
    /// Additional information related to the first advising party.
    /// </summary>
    public AdvisingPartyAdditionalInformation1? FirstAdvisingPartyAdditionalInformation { get; init; } 
    /// <summary>
    /// Additional information related to the second advising party.
    /// </summary>
    public AdvisingPartyAdditionalInformation1? SecondAdvisingPartyAdditionalInformation { get; init; } 
    /// <summary>
    /// Details concerning the confirmation of the proposed amendment.
    /// </summary>
    public UndertakingConfirmation1? ConfirmationDetails { get; init; } 
    /// <summary>
    /// Digital signature of the party providing additional undertaking amendment advice details.
    /// </summary>
    public ValueList<PartyAndSignature2> DigitalSignature { get; init; } = [];
    
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
        writer.WriteStartElement(null, "UdrtkgAmdmntMsg", xmlNamespace );
        UndertakingAmendmentMessage.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FirstAdvisingPartyAdditionalInformation is AdvisingPartyAdditionalInformation1 FirstAdvisingPartyAdditionalInformationValue)
        {
            writer.WriteStartElement(null, "FrstAdvsgPtyAddtlInf", xmlNamespace );
            FirstAdvisingPartyAdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondAdvisingPartyAdditionalInformation is AdvisingPartyAdditionalInformation1 SecondAdvisingPartyAdditionalInformationValue)
        {
            writer.WriteStartElement(null, "ScndAdvsgPtyAddtlInf", xmlNamespace );
            SecondAdvisingPartyAdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ConfirmationDetails is UndertakingConfirmation1 ConfirmationDetailsValue)
        {
            writer.WriteStartElement(null, "ConfDtls", xmlNamespace );
            ConfirmationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DgtlSgntr", xmlNamespace );
        DigitalSignature.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Amendment2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
