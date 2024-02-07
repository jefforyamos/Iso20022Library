﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OptionFeaturesFormat8SD1.  ISO2002 ID# _BAD3czFcEeGpgKb_ecoJPw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to specify the features that may apply to a corporate action option.
/// </summary>
public partial record OptionFeaturesFormat8SD1
     : IIsoXmlSerilizable<OptionFeaturesFormat8SD1>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Use of pro ration when the corporate action event type code is TEND or BIDS.
    /// あん分比例方式の適用有無が「無し」「未定」「非設定」.
    /// </summary>
    public required ProrationType1Code ProRationType { get; init; } 
    
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
        if (PlaceAndName is IsoMax350Text PlaceAndNameValue)
        {
            writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndNameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrRatnTp", xmlNamespace );
        writer.WriteValue(ProRationType.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static OptionFeaturesFormat8SD1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
