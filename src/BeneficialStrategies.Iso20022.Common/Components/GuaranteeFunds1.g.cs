﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GuaranteeFunds1.  ISO2002 ID# _IhrDAB92EeapDZRA0Hb6ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Guarantee funds details.
/// </summary>
public partial record GuaranteeFunds1
     : IIsoXmlSerilizable<GuaranteeFunds1>
{
    #nullable enable
    
    /// <summary>
    /// Type for the guarantee funds used.
    /// </summary>
    public required IsoMax35Text GuaranteeFundsUsageType { get; init; } 
    /// <summary>
    /// Owner and account number of the guarantee fund.
    /// </summary>
    public GuaranteeFundInformation1? GuaranteeFundInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "GrntFndsUsgTp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(GuaranteeFundsUsageType)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (GuaranteeFundInformation is GuaranteeFundInformation1 GuaranteeFundInformationValue)
        {
            writer.WriteStartElement(null, "GrntFndInf", xmlNamespace );
            GuaranteeFundInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static GuaranteeFunds1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
