﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative53.  ISO2002 ID# _ptSzgzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the taxation conditions.
/// </summary>
public partial record CorporateActionNarrative53
     : IIsoXmlSerilizable<CorporateActionNarrative53>
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public UpdatedAdditionalInformation5? AdditionalText { get; init; } 
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    public UpdatedAdditionalInformation5? NarrativeVersion { get; init; } 
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    public UpdatedAdditionalInformation5? InformationConditions { get; init; } 
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    public UpdatedAdditionalInformation5? InformationToComplyWith { get; init; } 
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    public UpdatedAdditionalInformation5? TaxationConditions { get; init; } 
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    public UpdatedAdditionalInformation5? Disclaimer { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public UpdatedAdditionalInformation5? PartyContactNarrative { get; init; } 
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    public UpdatedAdditionalInformation5? RegistrationDetails { get; init; } 
    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    public UpdatedAdditionalInformation5? BasketOrIndexInformation { get; init; } 
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    public UpdatedAdditionalInformation5? CertificationBreakdown { get; init; } 
    /// <summary>
    /// Provides additional information from the account servicer or a service provider solely intended for the next immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    public UpdatedAdditionalInformation1? ProcessingTextForNextIntermediary { get; init; } 
    
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
        if (AdditionalText is UpdatedAdditionalInformation5 AdditionalTextValue)
        {
            writer.WriteStartElement(null, "AddtlTxt", xmlNamespace );
            AdditionalTextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NarrativeVersion is UpdatedAdditionalInformation5 NarrativeVersionValue)
        {
            writer.WriteStartElement(null, "NrrtvVrsn", xmlNamespace );
            NarrativeVersionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InformationConditions is UpdatedAdditionalInformation5 InformationConditionsValue)
        {
            writer.WriteStartElement(null, "InfConds", xmlNamespace );
            InformationConditionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InformationToComplyWith is UpdatedAdditionalInformation5 InformationToComplyWithValue)
        {
            writer.WriteStartElement(null, "InfToCmplyWth", xmlNamespace );
            InformationToComplyWithValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxationConditions is UpdatedAdditionalInformation5 TaxationConditionsValue)
        {
            writer.WriteStartElement(null, "TaxtnConds", xmlNamespace );
            TaxationConditionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Disclaimer is UpdatedAdditionalInformation5 DisclaimerValue)
        {
            writer.WriteStartElement(null, "Dsclmr", xmlNamespace );
            DisclaimerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PartyContactNarrative is UpdatedAdditionalInformation5 PartyContactNarrativeValue)
        {
            writer.WriteStartElement(null, "PtyCtctNrrtv", xmlNamespace );
            PartyContactNarrativeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RegistrationDetails is UpdatedAdditionalInformation5 RegistrationDetailsValue)
        {
            writer.WriteStartElement(null, "RegnDtls", xmlNamespace );
            RegistrationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BasketOrIndexInformation is UpdatedAdditionalInformation5 BasketOrIndexInformationValue)
        {
            writer.WriteStartElement(null, "BsktOrIndxInf", xmlNamespace );
            BasketOrIndexInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CertificationBreakdown is UpdatedAdditionalInformation5 CertificationBreakdownValue)
        {
            writer.WriteStartElement(null, "CertfctnBrkdwn", xmlNamespace );
            CertificationBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProcessingTextForNextIntermediary is UpdatedAdditionalInformation1 ProcessingTextForNextIntermediaryValue)
        {
            writer.WriteStartElement(null, "PrcgTxtForNxtIntrmy", xmlNamespace );
            ProcessingTextForNextIntermediaryValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNarrative53 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
