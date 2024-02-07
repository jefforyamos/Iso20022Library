﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice42.  ISO2002 ID# _B6p5oSXoEeO4bIO_HtGo9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices of a corporate action.
/// </summary>
public partial record CorporateActionPrice42
     : IIsoXmlSerilizable<CorporateActionPrice42>
{
    #nullable enable
    
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    public PriceFormat23Choice_? MaximumPrice { get; init; } 
    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    public PriceFormat23Choice_? MinimumPrice { get; init; } 
    
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
        if (MaximumPrice is PriceFormat23Choice_ MaximumPriceValue)
        {
            writer.WriteStartElement(null, "MaxPric", xmlNamespace );
            MaximumPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumPrice is PriceFormat23Choice_ MinimumPriceValue)
        {
            writer.WriteStartElement(null, "MinPric", xmlNamespace );
            MinimumPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPrice42 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
