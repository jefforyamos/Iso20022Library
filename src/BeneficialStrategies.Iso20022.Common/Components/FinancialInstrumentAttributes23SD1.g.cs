﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributes23SD1.  ISO2002 ID# _7_9PY1IwEeGxk_7PmgdPEg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for UnderlyingSecurity.
/// </summary>
public partial record FinancialInstrumentAttributes23SD1
     : IIsoXmlSerilizable<FinancialInstrumentAttributes23SD1>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Classification of the Issuer or the Counterparty institution in case of a merger.
    /// 存続/消滅/親会社/子会社/未定の区分
    /// ※イベントタイプがMRGRの場合に、存続会社or消滅会社、親会社or子会社の通知を見分けるために必要。.
    /// </summary>
    public required InstitutionalClassificationCode PostEffectiveDateClassification { get; init; } 
    
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
        writer.WriteStartElement(null, "PstFctvDtClssfctn", xmlNamespace );
        writer.WriteValue(PostEffectiveDateClassification.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static FinancialInstrumentAttributes23SD1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
