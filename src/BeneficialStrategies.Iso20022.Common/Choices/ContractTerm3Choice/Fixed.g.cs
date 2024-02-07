﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Fixed.  ISO2002 ID# _tKrKc69_EemF0ZVFnxVu4g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ContractTerm3Choice;

/// <summary>
/// Transaction is  fixed term with a contractually agreed maturity date.
/// </summary>
public partial record Fixed : ContractTerm3Choice_
     , IIsoXmlSerilizable<Fixed>
{
    #nullable enable
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction. This information shall not be reported for open term agreements.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable agreement.
    /// </summary>
    public RepoTerminationOption2Code? TerminationOption { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (MaturityDate is IsoISODate MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TerminationOption is RepoTerminationOption2Code TerminationOptionValue)
        {
            writer.WriteStartElement(null, "TermntnOptn", xmlNamespace );
            writer.WriteValue(TerminationOptionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static new Fixed Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
