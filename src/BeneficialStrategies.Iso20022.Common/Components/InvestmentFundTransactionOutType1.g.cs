﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentFundTransactionOutType1.  ISO2002 ID# _UwBXetp-Ed-ak6NoX_4Aeg_-853943641.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment fund transactions that result in cash movements out of a fund, eg, redemption, switch-out.
/// </summary>
public partial record InvestmentFundTransactionOutType1
     : IIsoXmlSerilizable<InvestmentFundTransactionOutType1>
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction, expressed as a code.
    /// </summary>
    public required InvestmentFundTransactionOutType4Code Structured { get; init; } 
    /// <summary>
    /// Additional information about the type of transaction.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Strd", xmlNamespace );
        writer.WriteValue(Structured.ToString()); // Enum value
        writer.WriteEndElement();
        if (AdditionalInformation is IsoMax350Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(AdditionalInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static InvestmentFundTransactionOutType1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
