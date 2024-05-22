#version 410 core

in float Height;

out vec4 FragColor;

uniform sampler2D heightMap;
uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
uniform float heightScale; 


void main()
{
    float h = (Height + 16)/64.0f;
    //float color = 0.5f;
    float color = h;
    //if (h > 0.5f) {
    //    FragColor = vec4(0, color, 0, 1.0);
    //} else {
    //    FragColor = vec4(0, color, color, 1.0);
    //}
    //color = 0.5f;
    FragColor = vec4(color, color, color, 1.0);
}