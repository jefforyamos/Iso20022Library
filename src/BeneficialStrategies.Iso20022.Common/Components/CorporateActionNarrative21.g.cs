﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative21.  ISO2002 ID# _zRqDUfocEeCs84bkrlkROA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the registration details.
/// </summary>
public partial record CorporateActionNarrative21
     : IIsoXmlSerilizable<CorporateActionNarrative21>
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public IsoMax350Text? AdditionalText { get; init; } 
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    public IsoMax350Text? NarrativeVersion { get; init; } 
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    public IsoMax350Text? RegistrationDetails { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public IsoMax350Text? PartyContactNarrative { get; init; } 
    /// <summary>
    /// Disclaimer relative to the information provided in the message. It may be ignored for automated processing. No information about the instruction itself is allowed here.
    /// </summary>
    public IsoMax350Text? Disclaimer { get; init; } 
    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    public IsoMax350Text? BasketOrIndexInformation { get; init; } 
    /// <summary>
    /// Provides information required for the certification/breakdown.
    /// </summary>
    public IsoMax350Text? CertificationBreakdown { get; init; } 
    
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
        if (AdditionalText is IsoMax350Text AdditionalTextValue)
        {
            writer.WriteStartElement(null, "AddtlTxt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalTextValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (NarrativeVersion is IsoMax350Text NarrativeVersionValue)
        {
            writer.WriteStartElement(null, "NrrtvVrsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NarrativeVersionValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (RegistrationDetails is IsoMax350Text RegistrationDetailsValue)
        {
            writer.WriteStartElement(null, "RegnDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(RegistrationDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (PartyContactNarrative is IsoMax350Text PartyContactNarrativeValue)
        {
            writer.WriteStartElement(null, "PtyCtctNrrtv", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PartyContactNarrativeValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (Disclaimer is IsoMax350Text DisclaimerValue)
        {
            writer.WriteStartElement(null, "Dsclmr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(DisclaimerValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (BasketOrIndexInformation is IsoMax350Text BasketOrIndexInformationValue)
        {
            writer.WriteStartElement(null, "BsktOrIndxInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(BasketOrIndexInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (CertificationBreakdown is IsoMax350Text CertificationBreakdownValue)
        {
            writer.WriteStartElement(null, "CertfctnBrkdwn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(CertificationBreakdownValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNarrative21 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
