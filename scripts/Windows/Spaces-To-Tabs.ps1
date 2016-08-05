function Spaces-To-Tabs-For-Project()
{
    # Slighty modified version of code from this answer http://stackoverflow.com/a/10585857/1322693
	function GetFiles([string]$path, [string[]]$excludeDir)
	{
	    foreach ($item in Get-ChildItem $path)
	    {
	        if (Test-Path $item.FullName -PathType Container)
	        {
	        	if ($excludeDir | Where {$item -eq $_}) { continue }
	            
	            GetFiles $item.FullName $excludeDir
	        }
	        else
	        {
	        	# This script is only applying to cs files
				if ($item -notlike '*.cs') { continue }

				$item
	        }
	    }
	} 
	
	function Replace-Spaces-With-Tabs( $file )
	{
		$content = @()
		[IO.File]::ReadAllLines($file) | %{ $_ -replace ' {4,4}', "`t" } | %{ $content += $_ }
		[IO.File]::WriteAllLines($file, $content)
	}

	GetFiles '../../' @("obj","bin","scripts","codegen","docs","packages",".git",".vs")) | %{ Replace-Spaces-With-Tabs $_.FullName }
	
}
Spaces-To-Tabs-For-Project()
Remove-Item -Path Function:\Spaces-To-Tabs-For-Project