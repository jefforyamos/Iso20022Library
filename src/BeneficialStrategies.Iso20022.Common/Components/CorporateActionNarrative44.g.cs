﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative44.  ISO2002 ID# _4XQCke6MEeqc-LCjwLsUVg.
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
public partial record CorporateActionNarrative44
     : IIsoXmlSerilizable<CorporateActionNarrative44>
{
    #nullable enable
    
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    public UpdatedAdditionalInformation3? Offeror { get; init; } 
    /// <summary>
    /// Provides the new name of a company following a name change.
    /// </summary>
    public UpdatedAdditionalInformation3? NewCompanyName { get; init; } 
    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    public UpdatedURLlnformation4? URLAddress { get; init; } 
    
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
        if (Offeror is UpdatedAdditionalInformation3 OfferorValue)
        {
            writer.WriteStartElement(null, "Offerr", xmlNamespace );
            OfferorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NewCompanyName is UpdatedAdditionalInformation3 NewCompanyNameValue)
        {
            writer.WriteStartElement(null, "NewCpnyNm", xmlNamespace );
            NewCompanyNameValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (URLAddress is UpdatedURLlnformation4 URLAddressValue)
        {
            writer.WriteStartElement(null, "URLAdr", xmlNamespace );
            URLAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionNarrative44 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
