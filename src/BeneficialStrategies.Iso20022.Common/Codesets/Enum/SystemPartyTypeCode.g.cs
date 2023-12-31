﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SystemPartyTypeCode.  ISO2002 ID# _kpxjk-5NEeCisYr99QEiWA_-1377825526.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the party within a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kpxjk-5NEeCisYr99QEiWA_-1377825526")]
[Description(@"Specifies the type of the party within a system.")]
[Derivations(typeof(SystemPartyType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum SystemPartyTypeCode
{
    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.
    /// Encoded/decoded by serializers as "CSDY".
    /// </summary>
    [EnumMember(Value = "CSDY")]
    [IsoId("_kpxjlO5NEeCisYr99QEiWA_-1491664592")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.")]
    CentralSecuritiesDepository,
    
    /// <summary>
    /// As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.
    /// Encoded/decoded by serializers as "NCBK".
    /// </summary>
    [EnumMember(Value = "NCBK")]
    [IsoId("_kp6tgO5NEeCisYr99QEiWA_1628111679")]
    [Description(@"As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.")]
    NationalCentralBank,
    
    /// <summary>
    /// National central bank or a private bank used to settle the cash leg of securities settlements: it provides the cash account to support the settlement of the securities transactions of another financial institution in central bank money (CeBM).
    /// Encoded/decoded by serializers as "PMBK".
    /// </summary>
    [EnumMember(Value = "PMBK")]
    [IsoId("_kp6tge5NEeCisYr99QEiWA_-1366879028")]
    [Description(@"National central bank or a private bank used to settle the cash leg of securities settlements: it provides the cash account to support the settlement of the securities transactions of another financial institution in central bank money (CeBM).")]
    PaymentBank,
    
    /// <summary>
    /// Participant of a central securities depositary defined within the system, for which the account holder is the central securities depository.
    /// Encoded/decoded by serializers as "CSDP".
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("_kp6tgu5NEeCisYr99QEiWA_-166734643")]
    [Description(@"Participant of a central securities depositary defined within the system, for which the account holder is the central securities depository.")]
    CentralSecuritiesDepositoryParticipant,
    
    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.
    /// The infrastructure is external to the system executing the instruction.
    /// Encoded/decoded by serializers as "ECSD".
    /// </summary>
    [EnumMember(Value = "ECSD")]
    [IsoId("_kp6tg-5NEeCisYr99QEiWA_1619669745")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records. The infrastructure is external to the system executing the instruction.")]
    ExternalCentralSecuritiesDepository,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SystemPartyTypeCodeMetadataExtensions
{
    private static readonly SystemPartyTypeCodeDropdownSource _dropdownSource = new SystemPartyTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISystemPartyTypeCodeDropdownRow GetMetadata(this SystemPartyTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


