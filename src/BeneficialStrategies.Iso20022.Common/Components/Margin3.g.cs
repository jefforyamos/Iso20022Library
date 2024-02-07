﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Margin3.  ISO2002 ID# _-eMvBKMOEeCojJW5vEuTEQ_631064077.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the calculation of the margin.
/// </summary>
public partial record Margin3
     : IIsoXmlSerilizable<Margin3>
{
    #nullable enable
    
    /// <summary>
    /// Margin required for absorbing future market price fluctuations (market risks) occurring between the default of a member and close-out of unsettled securities positions by the central counterparty.
    /// </summary>
    public Amount2? InitialMargin { get; init; } 
    /// <summary>
    /// Provides details on the calculation of the variation margin.
    /// </summary>
    public VariationMargin3? VariationMargin { get; init; } 
    /// <summary>
    /// Provides details on the margin type and amount.
    /// </summary>
    public Margin4? OtherMargin { get; init; } 
    
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
        if (InitialMargin is Amount2 InitialMarginValue)
        {
            writer.WriteStartElement(null, "InitlMrgn", xmlNamespace );
            InitialMarginValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (VariationMargin is VariationMargin3 VariationMarginValue)
        {
            writer.WriteStartElement(null, "VartnMrgn", xmlNamespace );
            VariationMarginValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherMargin is Margin4 OtherMarginValue)
        {
            writer.WriteStartElement(null, "OthrMrgn", xmlNamespace );
            OtherMarginValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Margin3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
