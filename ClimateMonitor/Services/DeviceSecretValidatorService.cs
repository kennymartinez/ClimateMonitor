using System.Text.RegularExpressions;

namespace ClimateMonitor.Services;

public class DeviceSecretValidatorService
{
    private static readonly ISet<string> ValidSecrets = new HashSet<string>
    {
        "secret-ABC-123-XYZ-001",
        "secret-ABC-123-XYZ-002",
        "secret-ABC-123-XYZ-003"
    };

    private static readonly string SemanticRegex =
        @"^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)(?:-((?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+([0-9a-zA-Z-]+(?:\.[0-9a-zA-Z-]+)*))?$";

    public bool ValidateDeviceSecret(string deviceSecret) 
        => ValidSecrets.Contains(deviceSecret);
}
