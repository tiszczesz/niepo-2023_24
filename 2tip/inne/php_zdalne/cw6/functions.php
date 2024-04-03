<?php
function fromJson(string $filename): array
{
    $text = file_get_contents($filename);
    $recipes = json_decode($text, true);
    return $recipes;
}
function toCard(array $data): string
{
    $html = "<div class='card'>";
    $html .= "<h3>{$data['Name']}</h3>";
    $html .= "</div>";
    return $html;
}
