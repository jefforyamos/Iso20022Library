﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative2.  ISO2002 ID# _UMZtAdp-Ed-ak6NoX_4Aeg_325732462.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information about the CA event.
/// </summary>
public partial record CorporateActionNarrative2
     : IIsoXmlSerilizable<CorporateActionNarrative2>
{
    #nullable enable
    
    /// <summary>
    /// Provides conditional information related to the event, eg, an offer is subject to 50% acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    public IsoMax350Text? InformationConditions { get; init; } 
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, eg, not open to US/Canadian residents, QIB or SIL to be provided.
    /// </summary>
    public IsoMax350Text? InformationToComplyWith { get; init; } 
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the SLA.
    /// </summary>
    public IsoMax350Text? TaxationConditions { get; init; } 
    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, eg, beneficial ownership.
    /// </summary>
    public IsoMax350Text? DeclarationDetails { get; init; } 
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    public IsoMax350Text? RegistrationDetails { get; init; } 
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message.
    /// </summary>
    public IsoMax350Text? AdditionalText { get; init; } 
    
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
        if (InformationConditions is IsoMax350Text InformationConditionsValue)
        {
            writer.WriteStartElement(null, "InfConds", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(InformationConditionsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (InformationToComplyWith is IsoMax350Text InformationToComplyWithValue)
        {
            writer.WriteStartElement(null, "InfToCmplyWth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(InformationToComplyWithValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (TaxationConditions is IsoMax350Text TaxationConditionsValue)
        {
            writer.WriteStartElement(null, "TaxtnConds", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(TaxationConditionsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (DeclarationDetails is IsoMax350Text DeclarationDetailsValue)
        {
            writer.WriteStartElement(null, "DclrtnDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(DeclarationDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (RegistrationDetails is IsoMax350Text RegistrationDetailsValue)
        {
            writer.WriteStartElement(null, "RegnDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(RegistrationDetailsValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalText is IsoMax350Text AdditionalTextValue)
        {
            writer.WriteStartElement(null, "AddtlTxt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalTextValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNarrative2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
