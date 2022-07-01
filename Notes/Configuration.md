# Configuration

1. What is configuration?
2. How does it work and how is it setup?

Configuration is any set of settings, typically provided through one or more JSON files (e.g., appsettings.json).

**Chained Configuration**  
Configuration files are loaded in a chained order, where the last file loaded will take precedence. This is the default hierarchy order provided by the Host Builder.

1. appsettings.json
2. appsettings.\<environment>.json
3. App Secrets (i.e., secrets.json) - unique to each app and only runs locally, in development mode.
    1. Location: %APPDATA%\Microsoft\UserSecrets\\<user-secrets-id>\secrets.json
4. Environment Variables
5. Command Line Arguments
