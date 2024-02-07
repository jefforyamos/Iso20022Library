﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument72.  ISO2002 ID# _UjzVIddkEeispNOuywCdbA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifying features of a financial instrument that is a sub-set of an investment fund.
/// </summary>
public partial record FinancialInstrument72
     : IIsoXmlSerilizable<FinancialInstrument72>
{
    #nullable enable
    
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    /// <summary>
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Features of units offered by a fund. for example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, 'Class A', 'Class 2'.
    /// </summary>
    public IsoMax35Text? ClassType { get; init; } 
    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    public SecurityClassificationType2Choice_? ClassificationType { get; init; } 
    
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
        if (SupplementaryIdentification is IsoMax35Text SupplementaryIdentificationValue)
        {
            writer.WriteStartElement(null, "SplmtryId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SupplementaryIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SecuritiesForm is FormOfSecurity1Code SecuritiesFormValue)
        {
            writer.WriteStartElement(null, "SctiesForm", xmlNamespace );
            writer.WriteValue(SecuritiesFormValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ClassType is IsoMax35Text ClassTypeValue)
        {
            writer.WriteStartElement(null, "ClssTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClassTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DistributionPolicy is DistributionPolicy1Code DistributionPolicyValue)
        {
            writer.WriteStartElement(null, "DstrbtnPlcy", xmlNamespace );
            writer.WriteValue(DistributionPolicyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ClassificationType is SecurityClassificationType2Choice_ ClassificationTypeValue)
        {
            writer.WriteStartElement(null, "ClssfctnTp", xmlNamespace );
            ClassificationTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrument72 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
