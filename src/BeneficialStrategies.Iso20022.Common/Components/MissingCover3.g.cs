﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MissingCover3.  ISO2002 ID# _txvhAVkyEeGeoaLUQk__nA_85102909.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional cover details for the claim non receipt.
/// </summary>
public partial record MissingCover3
     : IIsoXmlSerilizable<MissingCover3>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the claim is related to a missing cover.
    /// </summary>
    public required IsoYesNoIndicator MissingCoverIndicator { get; init; } 
    /// <summary>
    /// Set of elements provided to update incorrect settlement information for the cover related to the received payment instruction.
    /// </summary>
    public SettlementInstruction3? CoverCorrection { get; init; } 
    
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
        writer.WriteStartElement(null, "MssngCoverInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(MissingCoverIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (CoverCorrection is SettlementInstruction3 CoverCorrectionValue)
        {
            writer.WriteStartElement(null, "CoverCrrctn", xmlNamespace );
            CoverCorrectionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MissingCover3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
