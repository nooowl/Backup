### Backup
##### Summary
Создание резервной копии всех указанных в файле настроек директорий и одиночных файлов.
##### Start

 ```bash
Backup <settings type> <settings file path>
```

Avalable settings types:
- xml
- json

##### Settings Format
Json example:
```json
{
  "SourceDirectories": [
    "Directory1",
    "Directory2"
  ],
  "SourceFiles": [
    "image.jpg"
  ],
  "TargetDirectory": "Temp"
}
```
Xml example:
```xml
<?xml version="1.0" encoding="utf-8"?>
<Settings>
    <SourceDirectories>
        <SourceDirectory>Directory1</SourceDirectory>
        <SourceDirectory>Directory2</SourceDirectory>
    </SourceDirectories>
    <SourceFiles>
        <SourceFile>image.jpg</SourceFile>
    </SourceFiles>
    <TargetDirectory>Temp</TargetDirectory>
</Settings>
```

