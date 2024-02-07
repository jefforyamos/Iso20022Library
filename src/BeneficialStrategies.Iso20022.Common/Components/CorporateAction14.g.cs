﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateAction14.  ISO2002 ID# _Jh0QpiUqEeO8eOSw0QN9mA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
public partial record CorporateAction14
     : IIsoXmlSerilizable<CorporateAction14>
{
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    public CorporateActionDate30? DateDetails { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public LotteryTypeFormat1Choice_? LotteryType { get; init; } 
    
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
        if (DateDetails is CorporateActionDate30 DateDetailsValue)
        {
            writer.WriteStartElement(null, "DtDtls", xmlNamespace );
            DateDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LotteryType is LotteryTypeFormat1Choice_ LotteryTypeValue)
        {
            writer.WriteStartElement(null, "LtryTp", xmlNamespace );
            LotteryTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateAction14 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
