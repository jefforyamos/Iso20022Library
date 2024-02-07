﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative20.  ISO2002 ID# _qhL-kfmgEeC4OqBGhVZKgA.
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
public partial record CorporateActionNarrative20
     : IIsoXmlSerilizable<CorporateActionNarrative20>
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public UpdatedAdditionalInformation3? AdditionalText { get; init; } 
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    public UpdatedAdditionalInformation3? NarrativeVersion { get; init; } 
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    public UpdatedAdditionalInformation1? InformationConditions { get; init; } 
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    public UpdatedAdditionalInformation1? InformationToComplyWith { get; init; } 
    /// <summary>
    /// Provides restriction(s) on securities.
    /// </summary>
    public UpdatedAdditionalInformation1? SecurityRestriction { get; init; } 
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    public UpdatedAdditionalInformation1? TaxationConditions { get; init; } 
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    public UpdatedAdditionalInformation1? Disclaimer { get; init; } 
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    public UpdatedAdditionalInformation1? CertificationBreakdown { get; init; } 
    
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
        if (AdditionalText is UpdatedAdditionalInformation3 AdditionalTextValue)
        {
            writer.WriteStartElement(null, "AddtlTxt", xmlNamespace );
            AdditionalTextValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NarrativeVersion is UpdatedAdditionalInformation3 NarrativeVersionValue)
        {
            writer.WriteStartElement(null, "NrrtvVrsn", xmlNamespace );
            NarrativeVersionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InformationConditions is UpdatedAdditionalInformation1 InformationConditionsValue)
        {
            writer.WriteStartElement(null, "InfConds", xmlNamespace );
            InformationConditionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InformationToComplyWith is UpdatedAdditionalInformation1 InformationToComplyWithValue)
        {
            writer.WriteStartElement(null, "InfToCmplyWth", xmlNamespace );
            InformationToComplyWithValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecurityRestriction is UpdatedAdditionalInformation1 SecurityRestrictionValue)
        {
            writer.WriteStartElement(null, "SctyRstrctn", xmlNamespace );
            SecurityRestrictionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxationConditions is UpdatedAdditionalInformation1 TaxationConditionsValue)
        {
            writer.WriteStartElement(null, "TaxtnConds", xmlNamespace );
            TaxationConditionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Disclaimer is UpdatedAdditionalInformation1 DisclaimerValue)
        {
            writer.WriteStartElement(null, "Dsclmr", xmlNamespace );
            DisclaimerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CertificationBreakdown is UpdatedAdditionalInformation1 CertificationBreakdownValue)
        {
            writer.WriteStartElement(null, "CertfctnBrkdwn", xmlNamespace );
            CertificationBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNarrative20 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
