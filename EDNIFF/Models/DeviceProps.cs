﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDNIFF.Models
{
    public class DeviceProps
    {
        public enum Processor
        {
            AddressWidth,
            Architecture,
            AssetTag,
            Availability,
            Caption,
            Characteristics,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CpuStatus,
            CreationClassName,
            CurrentClockSpeed,
            CurrentVoltage,
            DataWidth,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            ExtClock,
            Family,
            InstallDate,
            L2CacheSize,
            L2CacheSpeed,
            L3CacheSize,
            L3CacheSpeed,
            LastErrorCode,
            Level,
            LoadPercentage,
            Manufacturer,
            MaxClockSpeed,
            Name,
            NumberOfCores,
            NumberOfEnabledCore,
            NumberOfLogicalProcessors,
            OtherFamilyDescription,
            PartNumber,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            ProcessorId,
            ProcessorType,
            Revision,
            Role,
            SecondLevelAddressTranslationExtensions,
            SerialNumber,
            SocketDesignation,
            Status,
            StatusInfo,
            Stepping,
            SystemCreationClassName,
            SystemName,
            ThreadCount,
            UniqueId,
            UpgradeMethod,
            Version,
            VirtualizationFirmwareEnabled,
            VMMonitorModeExtensions,
            VoltageCaps,
            OA3xOriginalProductKey
        }
        public enum PNPDevice
        {
            Availability,
            Caption,
            ClassGuid,
            CompatibleID,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            HardwareID,
            InstallDate,
            LastErrorCode,
            Manufacturer,
            Name,
            PNPClass,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            Present,
            Service,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
        }
        public enum PhysicalMemory
        {
            Attributes,
            BankLabel,
            Capacity,
            Caption,
            ConfiguredClockSpeed,
            ConfiguredVoltage,
            CreationClassName,
            DataWidth,
            Description,
            DeviceLocator,
            FormFactor,
            HotSwappable,
            InstallDate,
            InterleaveDataDepth,
            InterleavePosition,
            Manufacturer,
            MaxVoltage,
            MemoryType,
            MinVoltage,
            Model,
            Name,
            OtherIdentifyingInfo,
            PartNumber,
            PositionInRow,
            PoweredOn,
            Removable,
            Replaceable,
            SerialNumber,
            SKU,
            SMBIOSMemoryType,
            Speed,
            Status,
            Tag,
            TotalWidth,
            TypeDetail,
            Version,
        }

        public enum FormFactor
        {
            Unknown = 0,
            Other = 1,
            SIP = 2,
            DIP = 3,
            ZIP = 4,
            SOJ = 5,
            Proprietary = 6,
            SIMM = 7,
            DIMM = 8,
            TSOP = 9,
            PGA = 10,
            RIMM = 11,
            SODIMM = 12,
            SRIMM = 13,
            SMD = 14,
            SSMP = 15,
            QFP = 16,
            TQFP = 17,
            SOIC = 18,
            LCC = 19,
            PLCC = 20,
            BGA = 21,
            FPBGA = 22,
            LGA = 23
        }

        public enum BIOS
        {
            BiosCharacteristics,
            BIOSVersion,
            BuildNumber,
            Caption,
            CodeSet,
            CurrentLanguage,
            Description,
            EmbeddedControllerMajorVersion,
            EmbeddedControllerMinorVersion,
            IdentificationCode,
            InstallableLanguages,
            InstallDate,
            LanguageEdition,
            ListOfLanguages,
            Manufacturer,
            Name,
            OtherTargetOS,
            PrimaryBIOS,
            ReleaseDate,
            SerialNumber,
            SMBIOSBIOSVersion,
            SMBIOSMajorVersion,
            SMBIOSMinorVersion,
            SMBIOSPresent,
            SoftwareElementID,
            SoftwareElementState,
            Status,
            SystemBiosMajorVersion,
            SystemBiosMinorVersion,
            TargetOperatingSystem,
            Version,

        }
        public enum CDROMDrive
        {
            Availability,
            Capabilities,
            CapabilityDescriptions,
            Caption,
            CompressionMethod,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            DefaultBlockSize,
            Description,
            DeviceID,
            Drive,
            DriveIntegrity,
            ErrorCleared,
            ErrorDescription,
            ErrorMethodology,
            FileSystemFlags,
            FileSystemFlagsEx,
            Id,
            InstallDate,
            LastErrorCode,
            Manufacturer,
            MaxBlockSize,
            MaximumComponentLength,
            MaxMediaSize,
            MediaLoaded,
            MediaType,
            MfrAssignedRevisionLevel,
            MinBlockSize,
            Name,
            NeedsCleaning,
            NumberOfMediaSupported,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            RevisionLevel,
            SCSIBus,
            SCSILogicalUnit,
            SCSIPort,
            SCSITargetId,
            SerialNumber,
            Size,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            TransferRate,
            VolumeName,
            VolumeSerialNumber,
        }

        public enum DisplayConfiguration
        {
            BitsPerPel,
            Caption,
            Description,
            DeviceName,
            DisplayFlags,
            DisplayFrequency,
            DitherType,
            DriverVersion,
            ICMIntent,
            ICMMethod,
            LogPixels,
            PelsHeight,
            PelsWidth,
            SettingID,
            SpecificationVersion,
        }

        public enum IDEController
        {
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            InstallDate,
            LastErrorCode,
            Manufacturer,
            MaxNumberControlled,
            Name,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            ProtocolSupported,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            TimeOfLastReset,

        }
        public enum PortConnector
        {
            Caption,
            ConnectorPinout,
            ConnectorType,
            CreationClassName,
            Description,
            ExternalReferenceDesignator,
            InstallDate,
            InternalReferenceDesignator,
            Manufacturer,
            Model,
            Name,
            OtherIdentifyingInfo,
            PartNumber,
            PortType,
            PoweredOn,
            SerialNumber,
            SKU,
            Status,
            Tag,
            Version,
            DEVPKEY_Device_LocationInfo,
            DEVPKEY_Device_BusReportedDeviceDesc
        }
        public enum SoundDevice
        {
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            DMABufferSize,
            ErrorCleared,
            ErrorDescription,
            InstallDate,
            LastErrorCode,
            Manufacturer,
            MPU401Address,
            Name,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            ProductName,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
        }
        public enum USBController
        {
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            InstallDate,
            LastErrorCode,
            Manufacturer,
            MaxNumberControlled,
            Name,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            ProtocolSupported,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            TimeOfLastReset,
            DEVPKEY_Device_LocationInfo,
            DEVPKEY_Device_BusReportedDeviceDesc
        }
        public enum VideoController
        {
            AcceleratorCapabilities,
            AdapterCompatibility,
            AdapterDACType,
            AdapterRAM,
            Availability,
            CapabilityDescriptions,
            Caption,
            ColorTableEntries,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            CurrentBitsPerPixel,
            CurrentHorizontalResolution,
            CurrentNumberOfColors,
            CurrentNumberOfColumns,
            CurrentNumberOfRows,
            CurrentRefreshRate,
            CurrentScanMode,
            CurrentVerticalResolution,
            Description,
            DeviceID,
            DeviceSpecificPens,
            DitherType,
            DriverDate,
            DriverVersion,
            ErrorCleared,
            ErrorDescription,
            ICMIntent,
            ICMMethod,
            InfFilename,
            InfSection,
            InstallDate,
            InstalledDisplayDrivers,
            LastErrorCode,
            MaxMemorySupported,
            MaxNumberControlled,
            MaxRefreshRate,
            MinRefreshRate,
            Monochrome,
            Name,
            NumberOfColorPlanes,
            NumberOfVideoPages,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            ProtocolSupported,
            ReservedSystemPaletteEntries,
            SpecificationVersion,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            SystemPaletteEntries,
            TimeOfLastReset,
            VideoArchitecture,
            VideoMemoryType,
            VideoMode,
            VideoModeDescription,
            VideoProcessor,

        }

        public enum DiskDrive
        {
            Availability,
            BytesPerSector,
            Capabilities,
            CapabilityDescriptions,
            Caption,
            CompressionMethod,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            DefaultBlockSize,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            ErrorMethodology,
            FirmwareRevision,
            Index,
            InstallDate,
            InterfaceType,
            LastErrorCode,
            Manufacturer,
            MaxBlockSize,
            MaxMediaSize,
            MediaLoaded,
            MediaType,
            BusType,
            MinBlockSize,
            Model,
            Name,
            NeedsCleaning,
            NumberOfMediaSupported,
            Partitions,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            SCSIBus,
            SCSILogicalUnit,
            SCSIPort,
            SCSITargetId,
            SectorsPerTrack,
            SerialNumber,
            Signature,
            Size,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            TotalCylinders,
            TotalHeads,
            TotalSectors,
            TotalTracks,
            TracksPerCylinder,
        }

        public enum DiskPartition
        {
            Access,
            Availability,
            BlockSize,
            Bootable,
            BootPartition,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            DiskIndex,
            ErrorCleared,
            ErrorDescription,
            ErrorMethodology,
            HiddenSectors,
            Index,
            InstallDate,
            LastErrorCode,
            Name,
            NumberOfBlocks,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            PrimaryPartition,
            Purpose,
            RewritePartition,
            Size,
            StartingOffset,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            Type,

        }

        public enum CacheMemory
        {
            Access,
            AdditionalErrorData,
            Associativity,
            Availability,
            BlockSize,
            CacheSpeed,
            CacheType,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CorrectableError,
            CreationClassName,
            CurrentSRAM,
            Description,
            DeviceID,
            EndingAddress,
            ErrorAccess,
            ErrorAddress,
            ErrorCleared,
            ErrorCorrectType,
            ErrorData,
            ErrorDataOrder,
            ErrorDescription,
            ErrorInfo,
            ErrorMethodology,
            ErrorResolution,
            ErrorTime,
            ErrorTransferSize,
            FlushTimer,
            InstallDate,
            InstalledSize,
            LastErrorCode,
            Level,
            LineSize,
            Location,
            MaxCacheSize,
            Name,
            NumberOfBlocks,
            OtherErrorDescription,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            Purpose,
            ReadPolicy,
            ReplacementPolicy,
            StartingAddress,
            Status,
            StatusInfo,
            SupportedSRAM,
            SystemCreationClassName,
            SystemLevelAddress,
            SystemName,
            WritePolicy,
        }

        public enum ComputerSystem
        {
            AdminPasswordStatus,
            AutomaticManagedPagefile,
            AutomaticResetBootOption,
            AutomaticResetCapability,
            BootOptionOnLimit,
            BootOptionOnWatchDog,
            BootROMSupported,
            BootStatus,
            BootupState,
            Caption,
            ChassisBootupState,
            ChassisSKUNumber,
            CreationClassName,
            CurrentTimeZone,
            DaylightInEffect,
            Description,
            DNSHostName,
            Domain,
            DomainRole,
            EnableDaylightSavingsTime,
            FrontPanelResetStatus,
            HypervisorPresent,
            InfraredSupported,
            InitialLoadInfo,
            InstallDate,
            KeyboardPasswordStatus,
            LastLoadInfo,
            Manufacturer,
            Model,
            Name,
            NameFormat,
            NetworkServerModeEnabled,
            NumberOfLogicalProcessors,
            NumberOfProcessors,
            OEMLogoBitmap,
            OEMStringArray,
            PartOfDomain,
            PauseAfterReset,
            PCSystemType,
            PCSystemTypeEx,
            PowerManagementCapabilities,
            PowerManagementSupported,
            PowerOnPasswordStatus,
            PowerState,
            PowerSupplyState,
            PrimaryOwnerContact,
            PrimaryOwnerName,
            ResetCapability,
            ResetCount,
            ResetLimit,
            Roles,
            Status,
            SupportContactDescription,
            SystemFamily,
            SystemSKUNumber,
            SystemStartupDelay,
            SystemStartupOptions,
            SystemStartupSetting,
            SystemType,
            ThermalState,
            TotalPhysicalMemory,
            UserName,
            WakeUpType,
            Workgroup,
        }

        public enum ComputerSystemProduct
        {
            Caption,
            Description,
            ElementName,
            IdentifyingNumber,
            InstanceID,
            Name,
            SKUNumber,
            UUID,
            Vendor,
            Version,
            WarrantyDuration,
            WarrantyStartDate,
        }
        public enum Keyboard
        {
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            InstallDate,
            IsLocked,
            LastErrorCode,
            Layout,
            Name,
            NumberOfFunctionKeys,
            Password,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            KeyboardLayout,
        }
        public enum NetworkAdapter
        {
            AdapterType,
            AdapterTypeId,
            AutoSense,
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            GUID,
            Index,
            InstallDate,
            Installed,
            InterfaceIndex,
            LastErrorCode,
            MACAddress,
            Manufacturer,
            MaxNumberControlled,
            MaxSpeed,
            Name,
            NetConnectionID,
            NetConnectionStatus,
            NetEnabled,
            NetworkAddresses,
            PermanentAddress,
            PhysicalAdapter,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            ProductName,
            ServiceName,
            Speed,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            TimeOfLastReset,

        }
        public enum PointingDevice
        {
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            DeviceInterface,
            DoubleSpeedThreshold,
            ErrorCleared,
            ErrorDescription,
            Handedness,
            HardwareType,
            InfFileName,
            InfSection,
            InstallDate,
            IsLocked,
            LastErrorCode,
            Manufacturer,
            Name,
            NumberOfButtons,
            PNPDeviceID,
            PointingType,
            PowerManagementCapabilities,
            PowerManagementSupported,
            QuadSpeedThreshold,
            Resolution,
            SampleRate,
            Status,
            StatusInfo,
            Synch,
            SystemCreationClassName,
            SystemName,
        }
        public enum TimeZone
        {
            Bias,
            Caption,
            DaylightBias,
            DaylightDay,
            DaylightDayOfWeek,
            DaylightHour,
            DaylightMillisecond,
            DaylightMinute,
            DaylightMonth,
            DaylightName,
            DaylightSecond,
            DaylightYear,
            Description,
            SettingID,
            StandardBias,
            StandardDay,
            StandardDayOfWeek,
            StandardHour,
            StandardMillisecond,
            StandardMinute,
            StandardMonth,
            StandardName,
            StandardSecond,
            StandardYear,
        }
        public enum WmiMonitorID
        {
            Active,
            InstanceName,
            ManufacturerName,
            ProductCodeID,
            SerialNumberID,
            UserFriendlyName,
            UserFriendlyNameLength,
            WeekOfManufacture,
            YearOfManufacture
        }
    }
}